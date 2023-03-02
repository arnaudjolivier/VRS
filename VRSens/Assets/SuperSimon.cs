using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSimon : MonoBehaviour
{

    [SerializeField] Material RedMaterial;
    [SerializeField] Material BlueMaterial;
    [SerializeField] Material GreenMaterial;
    [SerializeField] Material YellowMaterial;

    [SerializeField] Rigidbody RedButton;
    [SerializeField] Rigidbody BlueButton;
    [SerializeField] Rigidbody GreenButton;
    [SerializeField] Rigidbody YellowButton;

    [SerializeField] int MaxLvl;
    [SerializeField] float BaseSpeed;
    [SerializeField] float SpeedMultiplier;

    int ActualLvl;
    List<int> list = new List<int>();
    int index = 0;

    void Start()
    {
        ActualLvl = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextLvl();
        }
    }

    private void NextLvl()
    {
        list.Add(UnityEngine.Random.Range(0, 4));
        ActualLvl++;
        StartCoroutine(PlaySequence());
    }

    private IEnumerator PlaySequence()
    {
        float timeToWait = BaseSpeed / ActualLvl * SpeedMultiplier;
        for (int i = 0; i < ActualLvl; i++)
        {
            switch (list[i])
            {
                case 0:
                    BlueMaterial.EnableKeyword("_EMISSION");
                    BlueButton.AddForce(Vector3.right * 10 * ActualLvl);
                    yield return new WaitForSeconds(timeToWait);
                    BlueMaterial.DisableKeyword("_EMISSION");
                    BlueButton.AddForce(Vector3.left * 20 * ActualLvl);
                    yield return new WaitForSeconds(timeToWait);
                    BlueButton.AddForce(Vector3.right * 10 * ActualLvl);
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

    public void RedButtonPressed()
    {
        if (list[index] == 0)
        {
            index++;
            if (index == ActualLvl)
            {
                index = 0;
                NextLvl();
            }
        }
        else
        {
            Debug.Log("You lose");
        }
    }

    public void BlueButtonPressed()
    {
        if (list[index] == 1)
        {
            index++;
            if (index == ActualLvl)
            {
                index = 0;
                NextLvl();
            }
        }
        else
        {
            Debug.Log("You lose");
        }
    }

    public void GreenButtonPressed()
    {
        if (list[index] == 2)
        {
            index++;
            if (index == ActualLvl)
            {
                index = 0;
                NextLvl();
            }
        }
        else
        {
            Debug.Log("You lose");
        }
    }

    public void YellowButtonPressed()
    {
        if (list[index] == 3)
        {
            index++;
            if (index == ActualLvl)
            {
                index = 0;
                NextLvl();
            }
        }
        else
        {
            Debug.Log("You lose");
        }
    }
}