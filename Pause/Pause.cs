using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Example Satellite Reign pause mod.
/// </summary>
public class Pause : ISrPlugin
{
    //protected TimeManager.TimeScaler m_TacticalPauseTimeScaler;
    protected CivilianAI bob;
    protected DEBUG_text dtext;
    protected List<CivilianAI> CapturedAI;
    protected SRChat aaa;

    /// <summary>
    /// Plugin initialization 
    /// </summary>
    public void Initialize()
    {
		Debug.Log("Initializing Persuadertron testing mod");
        CapturedAI = new List<CivilianAI>();
        //m_TacticalPauseTimeScaler = TimeManager.AddTimeScaler();
        //CapturedAI.Clear();
    }

    /// <summary>
    /// Called once per frame.
    /// </summary>
    public void Update()
    {
		if (Manager.Get().GameInProgress) 
		{
            //Need callback handler when CivilianAI is despawned to remove from list

            if (Input.GetKeyDown(KeyCode.F11))
            {
                Debug.Log("~~F11 hit");
                Vector3 MoveTo = new Vector3(0, 8, 0);
                //bob.Flee(MoveTo, 0.5f, 30, 5);

                /*int NumAI = 0;
                CivilianAI[] MyAI = CivilianAI.FindObjectsOfType(typeof(CivilianAI)) as CivilianAI[];
                foreach (CivilianAI ThisAI in MyAI)
                {
                    ThisAI.Flee(MoveTo, 0.5f, 30, 5);
                    ++NumAI;
                }*/

                Collider[] Impacts = Physics.OverlapSphere(AgentAI.FirstSelectedAgentAi(true).GetPosition(), 8);
                int i = 0;
                while (i < Impacts.Length)
                {
                    //Impacts[i].SendMessage("AddDamage");
                    CivilianAI baa = Impacts[i].GetComponent<CivilianAI>();
                    //baa.GetInstanceID
                    if (baa)
                    {
                        baa.Knockback(MoveTo, 4);
                        if (CapturedAI.IndexOf(baa) == -1)
                        {
                            //Add to array
                            CapturedAI.Add(baa);
                        }
                        //CapturedAI[CapturedAIPos] = baa;
                        //++CapturedAIPos;
                    }
                    i++;
                }
                //aaa.CreateChatElement("test", "hi thar", true);
                //aaa.CreateChatElement("test2", "again", false);
                //Debug.Log("Total civs: " + NumAI);
            }
            else if (Input.GetKeyDown(KeyCode.F10))
            {
                Debug.Log("~~F10 hit");
                Vector3 MoveTo = new Vector3(0, 0, 0);
                //bob.Flee(MoveTo, 0.5f, 30, 500);
                //bob.Knockback
                //bob.RegisterEventCallback(AIEventNotification.Despawn, barr);

                /*CivilianAI[] MyAI = CivilianAI.FindObjectsOfType(typeof(CivilianAI)) as CivilianAI[];
                foreach (CivilianAI ThisAI in MyAI)
                {
                    ThisAI.Flee(MoveTo, 0.5f, 30, 500);
                }*/
                foreach (CivilianAI ThisAI in CapturedAI)
                {
                    ThisAI.Knockback(MoveTo, 8);
                    ThisAI.MoveTo(AgentAI.FirstSelectedAgentAi(true).GetPosition(), 5);
                    //Flee(MoveTo, 0.5f, 30, 100);
                }
                /*int i = 0;
                while (i < CapturedAIPos)
                {
                    CapturedAI[i].Knockback(MoveTo, 8);
                    ++i;
                }*/

                /*CapturedAI.ForEach(delegate (CivilianAI ThisAI)
                {
                    ThisAI.Flee(MoveTo, 0.5f, 30, 500);
                    ThisAI.Knockback(MoveTo, 8);
                });*/
            }
            else if (Input.GetKeyDown(KeyCode.F9))
            {
                Debug.Log("~~F9 hit");
                foreach (CivilianAI ThisAI in CapturedAI)
                {
                    ThisAI.MoveTo(AgentAI.FirstSelectedAgentAi(true).GetPosition(), 5);
                    //Flee(MoveTo, 0.5f, 30, 100);
                }

                /*Vector3 MoveTo = new Vector3(2, 4, 16);
                //bob.Knockback(MoveTo, 8);

                CivilianAI[] MyAI = CivilianAI.FindObjectsOfType(typeof(CivilianAI)) as CivilianAI[];
                foreach (CivilianAI ThisAI in MyAI)
                {
                    ThisAI.Knockback(MoveTo, 8);
                }*/
            }
            /*else if (Input.GetKeyDown(KeyCode.F8))
            {
                //CapturedAI.Clear();
            }*/
		}
    }

    public string GetName()
    {
        return "Persuadertron.";
    }
}

