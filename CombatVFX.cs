using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatVFX : MonoBehaviour
{
    private Animator anim;
    private GameObject weaponObject;
    private ParticleSystem particles;

    public BoxCollider[] boxCols;

    // Start is called before the first frame update

    void Start()
    {

    anim = GetComponent<Animator>();
     
    //GetWeaponObject();
    //GetParticleSystem();
    
    }

    // Update is called once per frame
    void Update()
    {
       /* if(!anim.GetBool("Weapon_Swing"))
        {
        particles.Pause(); 
        particles.Stop(true);   
        }

        if(anim.GetBool("Weapon_Swing") & particles.isPlaying == false)
        {
        particles.Play();    
        }
        */
    }

    void PlaySwingParticle()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        if(particles)
        {
        particles.Emit(25);
        }
    }

    void StopSwingParticle()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        if(particles)
        {
        particles.Stop();
        } 
    }

}
