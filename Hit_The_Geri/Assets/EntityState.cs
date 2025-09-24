using UnityEngine;

public abstract class EntityState //parent class (info about all states, what are they using, like timers, triggers,...shared functionality)
//abstract: cant be used directly, it is just a blueprint, we can create a new class and inherit from this one
{
    protected Player player;
    protected StateMachine stateMachine; //variable is private for every script except for those which inherit from the EntityState class
    protected string animBoolName;

    protected Animator anim;
    protected Rigidbody2D rb;

    public EntityState(Player player, StateMachine stateMachine, string animBoolName) //constructor
    {
        this.player = player;
        this.stateMachine = stateMachine; //this means it reffers to this class (Player)
        this.animBoolName = animBoolName;

        anim = player.anim;
        rb = player.rb;
    }

    //for the methods bellow we need a state machine (it cant work alone)
    public virtual void Enter()
    {
        //each time state is changed, enter is called
        anim.SetBool(animBoolName, true);
    }

    public virtual void Update()
    {
        //logic of a state
        Debug.Log("I run update of " + animBoolName);
    }

    public virtual void Exit()
    {
        //when we exit a state and change to a new one
        anim.SetBool(animBoolName, false);
    }
}
