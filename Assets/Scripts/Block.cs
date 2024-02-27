using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int Value;
    [SerializeField] private SpriteRenderer _renderer;


   public void Init(BlockType type){
        Value = type.value;
        _renderer.color = type.color;
   }
}
