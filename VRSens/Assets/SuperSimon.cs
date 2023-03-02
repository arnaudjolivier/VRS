using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSimon : MonoBehaviour
{
    [SerializeField] Animator RedButton;

    [SerializeField] int MaxLvl;
    [SerializeField] float BaseSpeed;
    [SerializeField] float SpeedMultiplier;

    int ActualLvl;
    List<int> list = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        ActualLvl = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextLvl();
        }
    }

    // add a random number to the list
    private void NextLvl()
    {
        list.Add(UnityEngine.Random.Range(0, 4));
        ActualLvl++;
        StartCoroutine(PlaySequence());
    }

    // corountine to make the button go down and glow
    private IEnumerator PlaySequence()
    {
        float timeToWait = BaseSpeed / ActualLvl * SpeedMultiplier;
        for (int i = 0; i < ActualLvl; i++)
        {
            switch (list[i])
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            yield return new WaitForSeconds(timeToWait);
        }   
    }
}
