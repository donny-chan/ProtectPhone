﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCharacter : MonoBehaviour
{
    public string name;
    public int hp;
    public int maxHp;
    public int atkDmg;
    public float moveSpeed;
    public float jumpForce;
    public int direction;

    private List<Effect> effects;
    public Pack backpack;

    public Rigidbody2D body;
    public Collider2D collider;
    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GetDir() {}
    public void GetPos() {}

    public void AddEffect(Effect effect) {}

    public void IncreaseHp(int amount) {}

    public void IncreaseMaxHp(int amount) {}

    public void IncreaseMoveSpeed(float amount) {}

    public void IncreaseEnergy(int amount) {}

    public void GainReward(Pack pack)
    {
        this.backpack.addPack(pack);
        Destroy(pack.gameObject);
    }
    public void addTool(int id)
    {
        this.backpack.addTool(id);
    }

    public virtual void BeDamaged(DamageCarrier damageCarrier) 
    {
        Debug.Log("is damaged");
    }

    public void AfterAttack(GameCharacter damaged) {}

    private void UseTool(Tool tool) {}

    private void IsDead() {}

    private void IsOnGround() {}    
}
