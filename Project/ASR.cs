﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Recognition.SrgsGrammar;
using System.Speech.Recognition;
using System.Windows.Forms;
using System.IO;

namespace Droid_Speaker
{
    public class AutomaticSpeechRecognition
    {
        #region Attribute
        private const string FILEPATH = @"D:\DEV\_Assistant\Assistant\Droid_speaker\Grammaire.grxml";
        private const string GRAMARTEMPLATE = @"<?xml version='1.0' encoding='UTF-8'?>
            <grammar version = '1.0' xml:lang='fr-FR' mode='voice' tag-format='semantics-ms/1.0' root='mouskie' xmlns='http://www.w3.org/2001/06/grammar'>
                  <rule id = 'mouskie' scope='public'>
                        <one-of>
                          {0}
                        </one-of>
                        <tag>$._value = $recognized.text;</tag>
                  </rule>
            </grammar>";

        private SpeechRecognitionEngine _asrEngine;
        private Label _recoText;
        private Label _commandText;
        private Label _devine;
        private Label _affiche;
        #endregion

        #region Properties
        public SpeechRecognitionEngine ASREngine
        {
            get { return _asrEngine; }
            set { _asrEngine = value; }
        }
        #endregion

        #region Constructor
        public AutomaticSpeechRecognition(ref Label recoText, ref Label commandText, ref Label devine, ref Label affiche)
        {
            GenerateGramar();
            //Les 4 labels dont le texte devra être changé
            //en fonction de ce qui est reconnu
            this._recoText = recoText;
            this._commandText = commandText;
            this._devine = devine;
            this._affiche = affiche;
            //Démarrage du moteur de reconnaissance vocale
            StartEngine();
        }
        #endregion

        #region Methods private
        private void GenerateGramar()
        {
            StringBuilder lines = new StringBuilder();
            List<string[]> syllabes = Droid_database.MySqlAdapter.ExecuteReader("select valeur from t_mot;");
            foreach (string[] syllabe in syllabes)
            {
                lines.AppendLine(string.Format("              <item>{0}</item>", syllabe[0]));
            }
            if (File.Exists(FILEPATH)) File.Delete(FILEPATH);
            using (StreamWriter sw = new StreamWriter(FILEPATH))
            {
                sw.Write(string.Format(GRAMARTEMPLATE, lines.ToString()));
            }
        }
        private void StartEngine()
        {
            //Création d'un document de la norme SRGS à partir du fichier grxml
            SrgsDocument xmlGrammar = new SrgsDocument(FILEPATH);
            //Création d'une grammaire depuis le fichier de grammaire
            Grammar grammar = new Grammar(xmlGrammar);
            //Création de l'objet traitant la reconnaissance vocale
            ASREngine = new SpeechRecognitionEngine();
            //Récupération du son du microphone
            ASREngine.SetInputToDefaultAudioDevice();
            //Chargement de la grammaire
            ASREngine.LoadGrammar(grammar);
            //Link des fonctions a appeler en cas de reconnaissance d'un texte
            ASREngine.SpeechRecognized += ASREngine_RecoFailled;
            ASREngine.SpeechRecognitionRejected += ASREngine_RecoSuccess;
            ASREngine.SpeechHypothesized += ASREngine_SpeechHypothesized;
            //Spécification du nombre maximum d'alternatives
            //Par exemple : b ou p ou d ou t, t ou d, i ou j, etc.
            //Utile pour les sons qui se ressemblent
            ASREngine.MaxAlternates = 4;
        }
        private void ASREngine_SpeechHypothesized(object sender, SpeechHypothesizedEventArgs e)
        {
            _recoText.Text = "Hypothèse : " + e.Result.Text;
            _devine.Text = "";
            _affiche.Text = "";
            _commandText.Text = "";
        }
        private void ASREngine_RecoSuccess(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            _recoText.Text = "Reconnaissance impossible";
            _devine.Text = "";
            _affiche.Text = "";
            _commandText.Text = "";
        }
        private void ASREngine_RecoFailled(object sender, SpeechRecognizedEventArgs e)
        {
            _recoText.Text = e.Result.Text;
            _devine.Text = "";
            _affiche.Text = "";
            //Récupération de la commande de base utilisée (QUIT ou LEARN)
            //string baseCommand = e.Result.Semantics["mouskie"].Value.ToString();
            //commandText.Text = baseCommand;
            //if (baseCommand.Equals("QUIT"))
            //    Environment.Exit(0);
            //else if (baseCommand.Equals("LEARN"))
            //{
            //    string dataType = e.Result.Semantics["data_type"].Value.ToString();
            //    commandText.Text += " " + dataType;
            //    string node = "";
            //    //Choix du noeud en fonction de la commande trouvée
            //    if (dataType.Equals("NUMBER"))
            //        node = "numbers";
            //    else if (dataType.Equals("LETTER"))
            //        node = "letters";
            //    try
            //    {   //Parcours des alternatives pour toutes les afficher
            //        for (int i = 0; i < e.Result.Alternates.ToArray().Length; i++)
            //        {
            //            string found = e.Result.Alternates.ToArray()[i].Semantics["data_type"][node].Value.ToString();
            //            if (i != 0)
            //                affiche.Text += " ou ";
            //            affiche.Text += found;
            //        }
            //    }
            //    catch { }
            //}
        }
        #endregion
    }
}