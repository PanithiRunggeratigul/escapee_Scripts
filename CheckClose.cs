using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckClose : MonoBehaviour
{
    public float offset;
    public bool objIsClose;
    public LayerMask Player;

    //public void Hide()
    //{
    //    gameObject.SetActive(false);
    //}

    //public void Show()
    //{
    //    gameObject.SetActive(true);
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, offset);
    }

    // Update is called once per frame
    void Update()
    {
        objIsClose = Physics.CheckSphere(transform.position, offset, Player);

        if (objIsClose)
        {
            gameObject.layer = LayerMask.NameToLayer("SpecialUI");
        }
        else
        {
            gameObject.layer = LayerMask.NameToLayer("InteractUI");
        }
    }
}
