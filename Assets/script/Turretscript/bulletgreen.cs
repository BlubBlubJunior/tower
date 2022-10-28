using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletgreen : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public int damage;
    
    public void seek(Transform _target)
    {
        target = _target;
    }
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position;
        float distancethisframe = speed * Time.deltaTime;

        if(dir.magnitude <= distancethisframe)
        {   
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distancethisframe, Space.World);
    }
    
    public void HitTarget()
    {

        enemy daamage = target.GetComponent<enemy>();
        if (target.gameObject.CompareTag("enemyrood"))
        {
            damage += 5;
        }
        if (target.gameObject.CompareTag("enemyblauw"))
        {
            damage += 10;
        }
        if (target.gameObject.CompareTag("enemygroen"))
        {
            damage += 20;
        }
        daamage.health -= damage;
        if (daamage.health <= 0)
        {
            FindObjectOfType<gamemanager>().gold += 5;
            Destroy(target.gameObject);
        }
        
        Destroy(gameObject);
        
    }
}
