using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class Checkpoint : MonoBehaviour
    {
        private SpriteRenderer renderer;
        private AudioSource clip;
        [SerializeField] private Sprite activatedSprite;

        public bool respawnFacingLeft;

        private void Awake()
        {
            renderer = GetComponent<SpriteRenderer>();
            clip = GetComponent<AudioSource>();
        }
        private void Reset()
        {
            GetComponent<BoxCollider2D>().isTrigger = true; 
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            PlayerCharacter c = collision.GetComponent<PlayerCharacter>();
            if(c != null)
            {
                c.SetChekpoint(this);
                if (renderer != null)
                {
                    renderer.sprite = activatedSprite; 
                    clip.Play();
                }
            }
        }
    }
}