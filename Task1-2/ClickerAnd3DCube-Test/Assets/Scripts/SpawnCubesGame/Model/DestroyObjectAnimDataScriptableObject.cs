using UnityEngine;

namespace SpawnCubesGame.Model
{
    [CreateAssetMenu(fileName = "DestroyObjectAnimData", menuName = "ClickerAnd3DCube-Test/DestroyObjectAnimDataScriptableObject", order = 1)]
    public class DestroyObjectAnimDataScriptableObject : ScriptableObject
    {
        [SerializeField] private float _destroyAnimTime = 0.5f;

        public float DestroyAnimTime => _destroyAnimTime;
    }
}