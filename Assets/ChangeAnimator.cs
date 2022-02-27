using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    public void getAnimatorDancing() {
        this.GetComponent<Animator>().Play("Dancing Twerk");
    }
    public void getAnimatorRumba() {
        this.GetComponent<Animator>().Play("Rumba Dancing");
    }
}
