using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSimon : MonoBehaviour
{
    [SerializeField] Animator RedButton;
    [SerializeField] Material BlueMaterial;
    [SerializeField] Material GreenMaterial;
    [SerializeField] Material YellowMaterial;

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
                    RedButton.Play();
                    break;
                case 1:
                    BlueMaterial.EnableKeyword("_EMISSION");
                    BlueButton.AddForce(Vector3.right * 10 * ActualLvl);
                    yield return new WaitForSeconds(timeToWait);
                    BlueMaterial.DisableKeyword("_EMISSION");
                    BlueButton.AddForce(Vector3.left * 20 * ActualLvl);
                    yield return new WaitForSeconds(timeToWait);
                    BlueButton.AddForce(Vector3.right * 10 * ActualLvl);
                    break;
                case 2:
                    GreenMaterial.EnableKeyword("_EMISSION");
                    GreenButton.AddForce(Vector3.right * 10 * ActualLvl);
                    yield return new WaitForSeconds(timeToWait);
                    GreenMaterial.DisableKeyword("_EMISSION");
                    GreenButton.AddForce(Vector3.left * 20 * ActualLvl);
                    yield return new WaitForSeconds(timeToWait);
                    GreenButton.AddForce(Vector3.right * 10 * ActualLvl);
                    break;
                case 3:
                    YellowMaterial.EnableKeyword("_EMISSION");
                    YellowButton.AddForce(Vector3.right * 10 * ActualLvl);
                    yield return new WaitForSeconds(timeToWait);
                    YellowMaterial.DisableKeyword("_EMISSION");
                    YellowButton.AddForce(Vector3.left * 20 * ActualLvl);
                    yield return new WaitForSeconds(timeToWait);
                    YellowButton.AddForce(Vector3.right * 10 * ActualLvl);
                    break;
            }
            yield return new WaitForSeconds(timeToWait);
        }   
    }
}
