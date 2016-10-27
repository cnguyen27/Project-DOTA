using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{
    private Animator c_anim;
    private SpriteRenderer c_sprite;
    // Use this for initialization
    void Start()
    {
        c_anim = GetComponent<Animator>();
        c_sprite = GetComponent<SpriteRenderer>();
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            Vector3 c_position = transform.position;
            Vector3 add1 = new Vector3(0, 1);
            print("hit");
            c_anim.SetBool("attacking", true);
            Collider[] hitEnemies = Physics.OverlapSphere(c_position += add1, 1);
            foreach (Collider enemy in hitEnemies)
            {
                
                GameObject hitEnemy = enemy.gameObject;
                // hitEnemy.health -= 1; 
                c_sprite.color = Color.red;
                WaitForSecondsRealtime wait = new WaitForSecondsRealtime(0.1f);
                c_sprite.color = Color.white;
            }
        }
        else c_anim.SetBool("attacking", false);
    }
}
