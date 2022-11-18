using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumePostProcessing : MonoBehaviour
{
    //[SerializeField] LensDistortion _lens;
    [SerializeField] Volume _volume;
    [SerializeField] Health _healthPlayer;

    LensDistortion _ld;
    float _lensValue;
    float _intensity;
    float _X;
    float _Y;
    float _scale;


    private void Start ()
    {
        _volume.profile.TryGet<LensDistortion> (out LensDistortion _ld);
        _intensity = _ld.intensity.value = 0f;
        _X = _ld.xMultiplier.value = 0f;
        _Y = _ld.yMultiplier.value = 0f;
        _scale = _ld.scale.value = 0f;
    }

    void Update()
    {
        if (_healthPlayer.CurrentHealth <= 0)
        {
            StartCoroutine(waitForEvolution(_ld.intensity , 0, 1, 3f));
            StartCoroutine(waitForEvolution(_ld.xMultiplier, 0, 1, 3f));
            StartCoroutine(waitForEvolution(_ld.yMultiplier, 0, 1, 3f));
            StartCoroutine(waitForEvolution(_ld.scale, 0, 1, 3f));
        }
    }

    IEnumerator waitForEvolution (ClampedFloatParameter param, float startValue, float endValue, float duration)//intensity,xmultiplier,ymultiplier et scale sont des ClampedParameter du coup on generalise.
    {
        var timer = 0f;//on met un timer à zero.
        param.value = startValue;//param = valeur de depart

        while (timer < duration)// tant que le timer et inferieur à la durée
        {
            yield return null;//la coroutine retourne une valeur nulle
            timer += Time.deltaTime;//Ajoute une contrainte de 

            param.value = Mathf.Lerp(startValue, endValue, timer/duration);//

        }
        param.value = endValue;//
    }
}

















            //_intensity += Time.deltaTime;
            //_X += Time.deltaTime;
            //_Y += Time.deltaTime;
            //_scale += Time.deltaTime;