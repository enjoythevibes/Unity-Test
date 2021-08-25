using System.Collections;
using System.Collections.Generic;
using SpawnCubesGame.Model;
using UnityEngine;

namespace SpawnCubesGame.Controller
{
    public class ObjectDestroyer : MonoBehaviour
    {
        public void Init(DestroyObjectAnimDataScriptableObject destroyObjectAnimData)
        {
            StartCoroutine(DoDestroy(destroyObjectAnimData));
        }

        private IEnumerator DoDestroy(DestroyObjectAnimDataScriptableObject destroyObjectAnimData)
        {
            var animTime = destroyObjectAnimData.DestroyAnimTime;
            var currentTime = 0f;
            var sizeFrom = transform.localScale;
            var sizeTo = Vector3.zero;
            while (currentTime < animTime)
            {
                var currentSize = Vector3.Lerp(sizeFrom, sizeTo, currentTime / animTime);
                transform.localScale = currentSize;
                currentTime += Time.deltaTime;
                yield return null;
            }
            Destroy(gameObject);
            yield break;
        }
    }
}