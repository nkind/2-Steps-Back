using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class SolvedChecker : MonoBehaviour{

    int solvedPieces = 0;

    public GameObject solution;

    private void Locked() {
        solvedPieces++;
        if (solvedPieces >= 16) {
            Instantiate(solution);
        }
    }

}
