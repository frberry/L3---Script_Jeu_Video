using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Monstre : MonoBehaviour
{
    public GameObject Player;
    private NavMeshAgent Mob;
    public float MobDistanceRun = 6.0f;
    //private Animator anim;
    private string state = "idle";
    private bool alive = true;
	
    Animator animator;
	List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();


	public void OnCollisionEnter (Collision infoCollision)
	{
		if(infoCollision.gameObject.name=="PlayerCapsule")
		{
			SceneManager.LoadSceneAsync("Screamer");
            Debug.Log("ici");
		}

	}

    // Start is called before the first frame update
    void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animator>();
        animator = GetComponent<Animator>();
        Mob.speed = 2f;
        Mob.acceleration = 3f;
		
        //anim.speed = 1.2f;
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (alive)
        {
             //anim.SetFloat("velocity",Mob.velocity.magnitude);
             if( state == "idle")
             {
                // marche aléatoire
                Vector3 randomPos = Random.insideUnitSphere*20f;
                NavMeshHit navHit;
                NavMesh.SamplePosition(transform.position + randomPos, out navHit,20f,NavMesh.AllAreas);
                Mob.SetDestination(navHit.position);
                state = "walk";
             }

             if(state == "walk")
             {
                if(Mob.remainingDistance <= Mob.stoppingDistance && !Mob.pathPending)
                {
                    state= "idle";
                }
             }
            //Poursuite joueur
            if(distance<MobDistanceRun)
            {
                Vector3 dirToPlayer = transform.position - Player.transform.position;
                Vector3 newPos = transform.position - dirToPlayer;
                Mob.SetDestination(newPos);
            }
        }
    }
}
