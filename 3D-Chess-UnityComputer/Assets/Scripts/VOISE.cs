using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VOISE : MonoBehaviour{

    private Dictionary <string, Action > keywordActions= new Dictionary<string, Action>();
    private KeywordRecognizer keywordRecognizer;
    public BoardManager boardManager ;

    void Start()
    {
        // PROBAR COMO LEE MEJOR  EL RECONOCIMIENTO DE VOZ
    
        keywordActions.Add("A1", prueba );
        keywordActions.Add("A2", prueba );
        keywordActions.Add("A3", prueba );
        keywordActions.Add("A4", prueba );
        keywordActions.Add("A5", prueba );
        keywordActions.Add("A6", prueba );
        keywordActions.Add("A7", prueba );
        keywordActions.Add("A8", prueba );
        
        keywordActions.Add("B1", prueba );
        keywordActions.Add("B2", prueba );
        keywordActions.Add("B3", prueba );
        keywordActions.Add("B4", prueba );
        keywordActions.Add("B5", prueba );
        keywordActions.Add("B6", prueba );
        keywordActions.Add("B7", prueba );
        keywordActions.Add("B8", prueba );

        keywordActions.Add("C1", prueba );
        keywordActions.Add("C2", prueba );
        keywordActions.Add("C3", prueba );
        keywordActions.Add("C4", prueba );
        keywordActions.Add("C5", prueba );
        keywordActions.Add("C6", prueba );
        keywordActions.Add("C7", prueba );
        keywordActions.Add("C8", prueba );

        keywordActions.Add("D1", prueba );
        keywordActions.Add("D2", prueba );
        keywordActions.Add("D3", prueba );
        keywordActions.Add("D4", prueba );
        keywordActions.Add("D5", prueba );
        keywordActions.Add("D6", prueba );
        keywordActions.Add("D7", prueba );
        keywordActions.Add("D8", prueba );

        keywordActions.Add("E1", prueba );
        keywordActions.Add("E2", prueba );
        keywordActions.Add("E3", prueba );
        keywordActions.Add("E4", prueba );
        keywordActions.Add("E5", prueba );
        keywordActions.Add("E6", prueba );
        keywordActions.Add("E7", prueba );
        keywordActions.Add("E8", prueba );

        keywordActions.Add("F1", prueba );
        keywordActions.Add("F2", prueba );
        keywordActions.Add("F3", prueba );
        keywordActions.Add("F4", prueba );
        keywordActions.Add("F5", prueba );
        keywordActions.Add("F6", prueba );
        keywordActions.Add("F7", prueba );
        keywordActions.Add("F8", prueba );

        keywordActions.Add("G1", prueba );
        keywordActions.Add("G2", prueba );
        keywordActions.Add("G3", prueba );
        keywordActions.Add("G4", prueba );
        keywordActions.Add("G5", prueba );
        keywordActions.Add("G6", prueba );
        keywordActions.Add("G7", prueba );
        keywordActions.Add("G8", prueba );

        keywordActions.Add("H1", prueba );
        keywordActions.Add("H2", prueba );
        keywordActions.Add("H3", prueba );
        keywordActions.Add("H4", prueba );
        keywordActions.Add("H5", prueba );
        keywordActions.Add("H6", prueba );
        keywordActions.Add("H7", prueba );
        keywordActions.Add("H8", prueba );

        keywordActions.Add("si", prueba );
        keywordActions.Add("hola", prueba );

        keywordRecognizer= new KeywordRecognizer(keywordActions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += OnKeywordsRecognized;
        keywordRecognizer.Start();
    }

    
    void Update()
    {
    }

    void prueba (){
        Debug.Log("te escucho");

    }

    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args){
        Debug.Log("key: "+ args.text);
        boardManager.UpdateSelection(args.text);
        keywordActions[args.text].Invoke();
    }


}
