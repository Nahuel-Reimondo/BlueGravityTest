using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePresenter<Model, View> : MonoBehaviour
    where Model : BaseModel
    where View : BaseView
{

    protected View view;
    protected Model model;

    public BasePresenter(Model model)
    {
        this.view = GetComponent<View>();
        this.GoWith(model);
    }


    protected virtual void Bind()
    {
        BindViewModelIfneeded();
    }

    private void BindViewModelIfneeded()
    {
       if(view == null)
            this.view = GetComponent<View>();
    }

    protected abstract void Unbind();

    public abstract void GoWith(Model model);
}

public abstract class BaseView : MonoBehaviour
{
}

public class BaseModel
{

}