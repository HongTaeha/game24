﻿using System.Collections; using System.Collections.Generic; using UnityEngine;  public class AddBullet : MonoBehaviour {      float nowTime;     public GameObject bullect;      // Use this for initialization  void Start () {         nowTime = Time.time;    }       // Update is called once per frame  void Update () {        if(Input.GetKeyDown(KeyCode.A) && Time.time - nowTime > 0.3f)         {                          GameObject b = Instantiate(bullect, transform.position, Quaternion.identity);             b.GetComponent<Bullet>().AddBullet(transform.position.x, transform.position.y, transform.position.z);             nowTime = Time.time;             Debug.Log("shoot");         }      }    }