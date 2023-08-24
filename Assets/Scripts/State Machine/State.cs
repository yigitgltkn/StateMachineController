using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State //abstract yazdigimiz icin statemachine de kolayca cagirbildik.
{
    public abstract void Enter();
    public abstract void Tick(float deltaTime);
    public abstract void Exit();
}
  /* unity ile ilgili islemler MonoBehaviour inheritine yazilir. Amac unity'deki projeyi etkileyecek bir kod degilse
     monobehaviour yazilmayabilir. */
