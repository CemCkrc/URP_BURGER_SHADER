using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BURGER.Controllers
{
    public class BurgerController : MonoBehaviour
    {
        private float _rotationSpeed;

        //Burger Material
        [SerializeField] private Material _burgerMaterial;

        //Burger GameObject
        private GameObject _burger;

        private void Awake() {
            MeshRenderer renderer = GetComponentInChildren<MeshRenderer>();
            renderer.material = new Material(_burgerMaterial); //Create new burger material
            _burger = renderer.gameObject;
            _burgerMaterial = renderer.material;
        }

        private void Update() 
        {
            _burger.transform.eulerAngles += Vector3.up * _rotationSpeed * Time.deltaTime;  
        }

        public void ChangeRotationSpeed(float speed) //Change rotation speed
        {
            _rotationSpeed = speed;
        }

        public void ChangeBurgerCookUp(float upValue) //Change burger cook up
        {
            _burgerMaterial.SetFloat("CookTimeUp", upValue);
        }

        public void ChangeBurgerCookDown(float downValue) //Change burger cook down
        {
            _burgerMaterial.SetFloat("CookTimeDown", downValue);
        }
    }
}
