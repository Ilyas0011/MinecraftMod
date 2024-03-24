using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        Application.targetFrameRate = 60;
        anim = GetComponent<Animator>();
    }
    public void MenuModsButton()
    {
        anim.Play("MenuOpenMods");
    }

    public void ModsBackButton()
    {
        anim.Play("ModsOpenMenu");
    }


    public void MenuPolicyButton()
    {
        anim.Play("MenuOpenPolicy");
    }

    public void PolicyBackButton()
    {
        anim.Play("PolicyOpenMenu");
    }

    public void ModsOneModButton()
    {
        anim.Play("ModsOpenOneMod");
    }

    public void OneModBackButton()
    {
        anim.Play("OneModOpenMods");
    }

    public void OneModDownoladButton()
    {
        anim.Play("OneModOpenDownolad");
    }

    public void DownoladBackButton()
    {
        anim.Play("DownoladOpenOneMod");
    }
}
