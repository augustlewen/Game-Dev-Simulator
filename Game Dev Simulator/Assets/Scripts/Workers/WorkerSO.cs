using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [CreateAssetMenu(fileName = "Worker", menuName = "ScriptableObjects/WorkerSO", order = 1)]
public class WorkerSO : ScriptableObject
{
    public string workerName;
    public GameObject workerGO;
    
    public Role workerRole;
    public List<WorkerSkill> Skills = new List<WorkerSkill>();

    void Start()
    {

    }

    public void CreateWorker(Role role)
    {
        workerRole = role;

        int enumLength = 0;

        switch(role)
        {
            case Role.Design: 
            enumLength = System.Enum.GetValues(typeof(Skill_Design)).Length;
            for(int i = 0; i < enumLength; i++)
            {
                WorkerSkill workerSkill = new WorkerSkill();
                // workerSkill.skillDesign =
                // Skills.Add()
            }
            break;
        }

        for(int i = 0; i < enumLength; i++)
        {
            
        }
    }


}
