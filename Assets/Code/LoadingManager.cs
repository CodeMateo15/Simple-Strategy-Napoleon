using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingManager : MonoBehaviour
{
    public bool load;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void LoadAIData()
    {
        if (load == true)
        {
            foreach (GameObject countries in GameObject.FindGameObjectsWithTag("country"))
            {
                countries.GetComponent<Control>().SpawnBorder();
                countries.GetComponent<Control>().espionage = Random.Range(0, 100);
                foreach (GameObject targetAI in GameObject.FindGameObjectsWithTag("AI"))
                {
                    if (targetAI.GetComponent<Country_AI>().borderingEnemies.Contains(this.gameObject))
                    {
                        targetAI.GetComponent<Control>().OnSoldiers();
                    }
                }
            }

            Debug.Log("load clicked");
            SaveSystem AIsaveto = SaveConvertor.LoadAI();

            GameObject.Find("information").GetComponent<countries>().playerCountry = AIsaveto.playerCountry;
            GameObject.Find("information").GetComponent<countries>().turnNumber = AIsaveto.turnNumber;

            GameObject.Find("information").GetComponent<countries>().franceGold = AIsaveto.FranceAIGold;
            GameObject.Find("information").GetComponent<countries>().spainGold = AIsaveto.SpainAIGold;
            GameObject.Find("information").GetComponent<countries>().portugalGold = AIsaveto.PortugalAIGold;
            GameObject.Find("information").GetComponent<countries>().UKGold = AIsaveto.UKAIGold;
            GameObject.Find("information").GetComponent<countries>().CRGold = AIsaveto.CRAIGold;
            GameObject.Find("information").GetComponent<countries>().moroccoGold = AIsaveto.MoroccoAIGold;
            GameObject.Find("information").GetComponent<countries>().algeriaGold = AIsaveto.AlgeriaAIGold;
            GameObject.Find("information").GetComponent<countries>().tunisGold = AIsaveto.TunisAIGold;
            GameObject.Find("information").GetComponent<countries>().sardGold = AIsaveto.SardiniaAIGold;
            GameObject.Find("information").GetComponent<countries>().sicilyGold = AIsaveto.SicilyAIGold;
            GameObject.Find("information").GetComponent<countries>().naplesGold = AIsaveto.NaplesAIGold;
            GameObject.Find("information").GetComponent<countries>().luccaGold = AIsaveto.LuccaAIGold;
            GameObject.Find("information").GetComponent<countries>().italyGold = AIsaveto.ItalyAIGold;
            GameObject.Find("information").GetComponent<countries>().helvetiaGold = AIsaveto.HelvetiaAIGold;
            GameObject.Find("information").GetComponent<countries>().austrianGold = AIsaveto.AustriaAIGold;
            GameObject.Find("information").GetComponent<countries>().ottomanGold = AIsaveto.OttomanAIGold;
            GameObject.Find("information").GetComponent<countries>().monteGold = AIsaveto.MontenegroAIGold;
            GameObject.Find("information").GetComponent<countries>().prussiaGold = AIsaveto.PrussiaAIGold;
            GameObject.Find("information").GetComponent<countries>().warsawGold = AIsaveto.WarsawAIGold;
            GameObject.Find("information").GetComponent<countries>().russianGold = AIsaveto.RussiaAIGold;
            GameObject.Find("information").GetComponent<countries>().swedenGold = AIsaveto.SwedenAIGold;
            GameObject.Find("information").GetComponent<countries>().norwayGold = AIsaveto.NorwayAIGold;
            GameObject.Find("information").GetComponent<countries>().francePopulation = AIsaveto.FranceAIPopulation;
            GameObject.Find("information").GetComponent<countries>().spainPopulation = AIsaveto.SpainAIPopulation;
            GameObject.Find("information").GetComponent<countries>().portugalPopulation = AIsaveto.PortugalAIPopulation;
            GameObject.Find("information").GetComponent<countries>().UKPopulation = AIsaveto.UKAIPopulation;
            GameObject.Find("information").GetComponent<countries>().CRPopulation = AIsaveto.CRAIPopulation;
            GameObject.Find("information").GetComponent<countries>().moroccoPopulation = AIsaveto.MoroccoAIPopulation;
            GameObject.Find("information").GetComponent<countries>().algeriaPopulation = AIsaveto.AlgeriaAIPopulation;
            GameObject.Find("information").GetComponent<countries>().tunisPopulation = AIsaveto.TunisAIPopulation;
            GameObject.Find("information").GetComponent<countries>().sardPopulation = AIsaveto.SardiniaAIPopulation;
            GameObject.Find("information").GetComponent<countries>().sicilyPopulation = AIsaveto.SicilyAIPopulation;
            GameObject.Find("information").GetComponent<countries>().naplesPopulation = AIsaveto.NaplesAIPopulation;
            GameObject.Find("information").GetComponent<countries>().luccaPopulation = AIsaveto.LuccaAIPopulation;
            GameObject.Find("information").GetComponent<countries>().italyPopulation = AIsaveto.ItalyAIPopulation;
            GameObject.Find("information").GetComponent<countries>().helvetiaPopulation = AIsaveto.HelvetiaAIPopulation;
            GameObject.Find("information").GetComponent<countries>().austrianPopulation = AIsaveto.AustriaAIPopulation;
            GameObject.Find("information").GetComponent<countries>().ottomanPopulation = AIsaveto.OttomanAIPopulation;
            GameObject.Find("information").GetComponent<countries>().montePopulation = AIsaveto.MontenegroAIPopulation;
            GameObject.Find("information").GetComponent<countries>().prussiaPopulation = AIsaveto.PrussiaAIPopulation;
            GameObject.Find("information").GetComponent<countries>().warsawPopulation = AIsaveto.WarsawAIPopulation;
            GameObject.Find("information").GetComponent<countries>().russianPopulation = AIsaveto.RussiaAIPopulation;
            GameObject.Find("information").GetComponent<countries>().swedenPopulation = AIsaveto.SwedenAIPopulation;
            GameObject.Find("information").GetComponent<countries>().norwayPopulation = AIsaveto.NorwayAIPopulation;
            GameObject.Find("information").GetComponent<countries>().franceMaterial = AIsaveto.FranceAIMaterial;
            GameObject.Find("information").GetComponent<countries>().spainMaterial = AIsaveto.SpainAIMaterial;
            GameObject.Find("information").GetComponent<countries>().portugalMaterial = AIsaveto.PortugalAIMaterial;
            GameObject.Find("information").GetComponent<countries>().UKMaterial = AIsaveto.UKAIMaterial;
            GameObject.Find("information").GetComponent<countries>().CRMaterial = AIsaveto.CRAIMaterial;
            GameObject.Find("information").GetComponent<countries>().moroccoMaterial = AIsaveto.MoroccoAIMaterial;
            GameObject.Find("information").GetComponent<countries>().algeriaMaterial = AIsaveto.AlgeriaAIMaterial;
            GameObject.Find("information").GetComponent<countries>().tunisMaterial = AIsaveto.TunisAIMaterial;
            GameObject.Find("information").GetComponent<countries>().sardMaterial = AIsaveto.SardiniaAIMaterial;
            GameObject.Find("information").GetComponent<countries>().sicilyMaterial = AIsaveto.SicilyAIMaterial;
            GameObject.Find("information").GetComponent<countries>().naplesMaterial = AIsaveto.NaplesAIMaterial;
            GameObject.Find("information").GetComponent<countries>().luccaMaterial = AIsaveto.LuccaAIMaterial;
            GameObject.Find("information").GetComponent<countries>().italyMaterial = AIsaveto.ItalyAIMaterial;
            GameObject.Find("information").GetComponent<countries>().helvetiaMaterial = AIsaveto.HelvetiaAIMaterial;
            GameObject.Find("information").GetComponent<countries>().austrianMaterial = AIsaveto.AustriaAIMaterial;
            GameObject.Find("information").GetComponent<countries>().ottomanMaterial = AIsaveto.OttomanAIMaterial;
            GameObject.Find("information").GetComponent<countries>().monteMaterial = AIsaveto.MontenegroAIMaterial;
            GameObject.Find("information").GetComponent<countries>().prussiaMaterial = AIsaveto.PrussiaAIMaterial;
            GameObject.Find("information").GetComponent<countries>().warsawMaterial = AIsaveto.WarsawAIMaterial;
            GameObject.Find("information").GetComponent<countries>().russianMaterial = AIsaveto.RussiaAIMaterial;
            GameObject.Find("information").GetComponent<countries>().swedenMaterial = AIsaveto.SwedenAIMaterial;
            GameObject.Find("information").GetComponent<countries>().norwayMaterial = AIsaveto.NorwayAIMaterial;

            GameObject.Find("france_nw").GetComponent<Control>().controller = AIsaveto.FNWcontroller;
            GameObject.Find("france_nw").GetComponent<Control>().cavalry = AIsaveto.FNWCavalry;
            GameObject.Find("france_nw").GetComponent<Control>().infantry = AIsaveto.FNWInfantry;
            GameObject.Find("france_nw").GetComponent<Control>().artillery = AIsaveto.FNWArtillery;
            GameObject.Find("france_se").GetComponent<Control>().controller = AIsaveto.FSEcontroller;
            GameObject.Find("france_se").GetComponent<Control>().cavalry = AIsaveto.FSECavalry;
            GameObject.Find("france_se").GetComponent<Control>().infantry = AIsaveto.FSEInfantry;
            GameObject.Find("france_se").GetComponent<Control>().artillery = AIsaveto.FSEArtillery;
            GameObject.Find("france_ne").GetComponent<Control>().controller = AIsaveto.FNEcontroller;
            GameObject.Find("france_ne").GetComponent<Control>().cavalry = AIsaveto.FNECavalry;
            GameObject.Find("france_ne").GetComponent<Control>().infantry = AIsaveto.FNEInfantry;
            GameObject.Find("france_ne").GetComponent<Control>().artillery = AIsaveto.FNEArtillery;
            GameObject.Find("france_sw").GetComponent<Control>().controller = AIsaveto.FSWcontroller;
            GameObject.Find("france_sw").GetComponent<Control>().cavalry = AIsaveto.FSWCavalry;
            GameObject.Find("france_sw").GetComponent<Control>().infantry = AIsaveto.FSWInfantry;
            GameObject.Find("france_sw").GetComponent<Control>().artillery = AIsaveto.FSWArtillery;
            GameObject.Find("corsica").GetComponent<Control>().controller = AIsaveto.CORcontroller;
            GameObject.Find("corsica").GetComponent<Control>().cavalry = AIsaveto.CORCavalry;
            GameObject.Find("corsica").GetComponent<Control>().infantry = AIsaveto.CORInfantry;
            GameObject.Find("corsica").GetComponent<Control>().artillery = AIsaveto.CORArtillery;
            GameObject.Find("rome").GetComponent<Control>().controller = AIsaveto.ROMEcontroller;
            GameObject.Find("rome").GetComponent<Control>().cavalry = AIsaveto.ROMECavalry;
            GameObject.Find("rome").GetComponent<Control>().infantry = AIsaveto.ROMEInfantry;
            GameObject.Find("rome").GetComponent<Control>().artillery = AIsaveto.ROMEArtillery;
            GameObject.Find("croatia_w").GetComponent<Control>().controller = AIsaveto.C_Wcontroller;
            GameObject.Find("croatia_w").GetComponent<Control>().cavalry = AIsaveto.C_WCavalry;
            GameObject.Find("croatia_w").GetComponent<Control>().infantry = AIsaveto.C_WInfantry;
            GameObject.Find("croatia_w").GetComponent<Control>().artillery = AIsaveto.C_WArtillery;
            GameObject.Find("croatia_e").GetComponent<Control>().controller = AIsaveto.C_Econtroller;
            GameObject.Find("croatia_e").GetComponent<Control>().cavalry = AIsaveto.C_ECavalry;
            GameObject.Find("croatia_e").GetComponent<Control>().infantry = AIsaveto.C_EInfantry;
            GameObject.Find("croatia_e").GetComponent<Control>().artillery = AIsaveto.C_EArtillery;
            GameObject.Find("spain_n").GetComponent<Control>().controller = AIsaveto.SNcontroller;
            GameObject.Find("spain_n").GetComponent<Control>().cavalry = AIsaveto.SNCavalry;
            GameObject.Find("spain_n").GetComponent<Control>().infantry = AIsaveto.SNInfantry;
            GameObject.Find("spain_n").GetComponent<Control>().artillery = AIsaveto.SNArtillery;
            GameObject.Find("spain_s").GetComponent<Control>().controller = AIsaveto.SScontroller;
            GameObject.Find("spain_s").GetComponent<Control>().cavalry = AIsaveto.SSCavalry;
            GameObject.Find("spain_s").GetComponent<Control>().infantry = AIsaveto.SSInfantry;
            GameObject.Find("spain_s").GetComponent<Control>().artillery = AIsaveto.SSArtillery;
            GameObject.Find("portugal_n").GetComponent<Control>().controller = AIsaveto.PNcontroller;
            GameObject.Find("portugal_n").GetComponent<Control>().cavalry = AIsaveto.PNCavalry;
            GameObject.Find("portugal_n").GetComponent<Control>().infantry = AIsaveto.PNInfantry;
            GameObject.Find("portugal_n").GetComponent<Control>().artillery = AIsaveto.PNArtillery;
            GameObject.Find("portugal_s").GetComponent<Control>().controller = AIsaveto.PScontroller;
            GameObject.Find("portugal_s").GetComponent<Control>().cavalry = AIsaveto.PSCavalry;
            GameObject.Find("portugal_s").GetComponent<Control>().infantry = AIsaveto.PSInfantry;
            GameObject.Find("portugal_s").GetComponent<Control>().artillery = AIsaveto.PSArtillery;
            GameObject.Find("ireland_n").GetComponent<Control>().controller = AIsaveto.INcontroller;
            GameObject.Find("ireland_n").GetComponent<Control>().cavalry = AIsaveto.INCavalry;
            GameObject.Find("ireland_n").GetComponent<Control>().infantry = AIsaveto.INInfantry;
            GameObject.Find("ireland_n").GetComponent<Control>().artillery = AIsaveto.INArtillery;
            GameObject.Find("ireland_s").GetComponent<Control>().controller = AIsaveto.IScontroller;
            GameObject.Find("ireland_s").GetComponent<Control>().cavalry = AIsaveto.ISCavalry;
            GameObject.Find("ireland_s").GetComponent<Control>().infantry = AIsaveto.ISInfantry;
            GameObject.Find("ireland_s").GetComponent<Control>().artillery = AIsaveto.ISArtillery;
            GameObject.Find("england_e").GetComponent<Control>().controller = AIsaveto.EEcontroller;
            GameObject.Find("england_e").GetComponent<Control>().cavalry = AIsaveto.EECavalry;
            GameObject.Find("england_e").GetComponent<Control>().infantry = AIsaveto.EEInfantry;
            GameObject.Find("england_e").GetComponent<Control>().artillery = AIsaveto.EEArtillery;
            GameObject.Find("england_w").GetComponent<Control>().controller = AIsaveto.EWcontroller;
            GameObject.Find("england_w").GetComponent<Control>().cavalry = AIsaveto.EWCavalry;
            GameObject.Find("england_w").GetComponent<Control>().infantry = AIsaveto.EWInfantry;
            GameObject.Find("england_w").GetComponent<Control>().artillery = AIsaveto.EWArtillery;
            GameObject.Find("scotland").GetComponent<Control>().controller = AIsaveto.Scontroller;
            GameObject.Find("scotland").GetComponent<Control>().cavalry = AIsaveto.SCavalry;
            GameObject.Find("scotland").GetComponent<Control>().infantry = AIsaveto.SInfantry;
            GameObject.Find("scotland").GetComponent<Control>().artillery = AIsaveto.SArtillery;
            GameObject.Find("cr_n").GetComponent<Control>().controller = AIsaveto.CNcontroller;
            GameObject.Find("cr_n").GetComponent<Control>().cavalry = AIsaveto.CNCavalry;
            GameObject.Find("cr_n").GetComponent<Control>().infantry = AIsaveto.CNInfantry;
            GameObject.Find("cr_n").GetComponent<Control>().artillery = AIsaveto.CNArtillery;
            GameObject.Find("cr_s").GetComponent<Control>().controller = AIsaveto.CScontroller;
            GameObject.Find("cr_s").GetComponent<Control>().cavalry = AIsaveto.CSCavalry;
            GameObject.Find("cr_s").GetComponent<Control>().infantry = AIsaveto.CSInfantry;
            GameObject.Find("cr_s").GetComponent<Control>().artillery = AIsaveto.CSArtillery;
            GameObject.Find("morocco_e").GetComponent<Control>().controller = AIsaveto.MEcontroller;
            GameObject.Find("morocco_e").GetComponent<Control>().cavalry = AIsaveto.MECavalry;
            GameObject.Find("morocco_e").GetComponent<Control>().infantry = AIsaveto.MEInfantry;
            GameObject.Find("morocco_e").GetComponent<Control>().artillery = AIsaveto.MEArtillery;
            GameObject.Find("morocco_w").GetComponent<Control>().controller = AIsaveto.MWcontroller;
            GameObject.Find("morocco_w").GetComponent<Control>().cavalry = AIsaveto.MWCavalry;
            GameObject.Find("morocco_w").GetComponent<Control>().infantry = AIsaveto.MWInfantry;
            GameObject.Find("morocco_w").GetComponent<Control>().artillery = AIsaveto.MWArtillery;
            GameObject.Find("algeria_e").GetComponent<Control>().controller = AIsaveto.AEcontroller;
            GameObject.Find("algeria_e").GetComponent<Control>().cavalry = AIsaveto.AECavalry;
            GameObject.Find("algeria_e").GetComponent<Control>().infantry = AIsaveto.AEInfantry;
            GameObject.Find("algeria_e").GetComponent<Control>().artillery = AIsaveto.AEArtillery;
            GameObject.Find("algeria_m").GetComponent<Control>().controller = AIsaveto.ACcontroller;
            GameObject.Find("algeria_m").GetComponent<Control>().cavalry = AIsaveto.ACCavalry;
            GameObject.Find("algeria_m").GetComponent<Control>().infantry = AIsaveto.ACInfantry;
            GameObject.Find("algeria_m").GetComponent<Control>().artillery = AIsaveto.ACArtillery;
            GameObject.Find("algeria_w").GetComponent<Control>().controller = AIsaveto.AWcontroller;
            GameObject.Find("algeria_w").GetComponent<Control>().cavalry = AIsaveto.AWCavalry;
            GameObject.Find("algeria_w").GetComponent<Control>().infantry = AIsaveto.AWInfantry;
            GameObject.Find("algeria_w").GetComponent<Control>().artillery = AIsaveto.AWArtillery;
            GameObject.Find("tunis_n").GetComponent<Control>().controller = AIsaveto.TNcontroller;
            GameObject.Find("tunis_n").GetComponent<Control>().cavalry = AIsaveto.TNCavalry;
            GameObject.Find("tunis_n").GetComponent<Control>().infantry = AIsaveto.TNInfantry;
            GameObject.Find("tunis_n").GetComponent<Control>().artillery = AIsaveto.TNArtillery;
            GameObject.Find("tunis_s").GetComponent<Control>().controller = AIsaveto.TScontroller;
            GameObject.Find("tunis_s").GetComponent<Control>().cavalry = AIsaveto.TSCavalry;
            GameObject.Find("tunis_s").GetComponent<Control>().infantry = AIsaveto.TSInfantry;
            GameObject.Find("tunis_s").GetComponent<Control>().artillery = AIsaveto.TSArtillery;
            GameObject.Find("sardinia_c").GetComponent<Control>().controller = AIsaveto.SACcontroller;
            GameObject.Find("sardinia_c").GetComponent<Control>().cavalry = AIsaveto.SACCavalry;
            GameObject.Find("sardinia_c").GetComponent<Control>().infantry = AIsaveto.SACInfantry;
            GameObject.Find("sardinia_c").GetComponent<Control>().artillery = AIsaveto.SACArtillery;
            GameObject.Find("sicily_c").GetComponent<Control>().controller = AIsaveto.SICcontroller;
            GameObject.Find("sicily_c").GetComponent<Control>().cavalry = AIsaveto.SICCavalry;
            GameObject.Find("sicily_c").GetComponent<Control>().infantry = AIsaveto.SICInfantry;
            GameObject.Find("sicily_c").GetComponent<Control>().artillery = AIsaveto.SICArtillery;
            GameObject.Find("naples_e").GetComponent<Control>().controller = AIsaveto.NEcontroller;
            GameObject.Find("naples_e").GetComponent<Control>().cavalry = AIsaveto.NECavalry;
            GameObject.Find("naples_e").GetComponent<Control>().infantry = AIsaveto.NEInfantry;
            GameObject.Find("naples_e").GetComponent<Control>().artillery = AIsaveto.NEArtillery;
            GameObject.Find("naples_w").GetComponent<Control>().controller = AIsaveto.NWcontroller;
            GameObject.Find("naples_w").GetComponent<Control>().cavalry = AIsaveto.NWCavalry;
            GameObject.Find("naples_w").GetComponent<Control>().infantry = AIsaveto.NWInfantry;
            GameObject.Find("naples_w").GetComponent<Control>().artillery = AIsaveto.NWArtillery;
            GameObject.Find("naples_n").GetComponent<Control>().controller = AIsaveto.NNcontroller;
            GameObject.Find("naples_n").GetComponent<Control>().cavalry = AIsaveto.NNCavalry;
            GameObject.Find("naples_n").GetComponent<Control>().infantry = AIsaveto.NNInfantry;
            GameObject.Find("naples_n").GetComponent<Control>().artillery = AIsaveto.NNArtillery;
            GameObject.Find("lucca").GetComponent<Control>().controller = AIsaveto.Lcontroller;
            GameObject.Find("lucca").GetComponent<Control>().cavalry = AIsaveto.LCavalry;
            GameObject.Find("lucca").GetComponent<Control>().infantry = AIsaveto.LInfantry;
            GameObject.Find("lucca").GetComponent<Control>().artillery = AIsaveto.LArtillery;
            GameObject.Find("italy_n").GetComponent<Control>().controller = AIsaveto.ITNcontroller;
            GameObject.Find("italy_n").GetComponent<Control>().cavalry = AIsaveto.ITNCavalry;
            GameObject.Find("italy_n").GetComponent<Control>().infantry = AIsaveto.ITNInfantry;
            GameObject.Find("italy_n").GetComponent<Control>().artillery = AIsaveto.ITNArtillery;
            GameObject.Find("italy_s").GetComponent<Control>().controller = AIsaveto.ITScontroller;
            GameObject.Find("italy_s").GetComponent<Control>().cavalry = AIsaveto.ITSCavalry;
            GameObject.Find("italy_s").GetComponent<Control>().infantry = AIsaveto.ITSInfantry;
            GameObject.Find("italy_s").GetComponent<Control>().artillery = AIsaveto.ITSArtillery;
            GameObject.Find("helvetia_c").GetComponent<Control>().controller = AIsaveto.HCcontroller;
            GameObject.Find("helvetia_c").GetComponent<Control>().cavalry = AIsaveto.HCCavalry;
            GameObject.Find("helvetia_c").GetComponent<Control>().infantry = AIsaveto.HCInfantry;
            GameObject.Find("helvetia_c").GetComponent<Control>().artillery = AIsaveto.HCArtillery;
            GameObject.Find("austria_ne").GetComponent<Control>().controller = AIsaveto.ANEcontroller;
            GameObject.Find("austria_ne").GetComponent<Control>().cavalry = AIsaveto.ANECavalry;
            GameObject.Find("austria_ne").GetComponent<Control>().infantry = AIsaveto.ANEInfantry;
            GameObject.Find("austria_ne").GetComponent<Control>().artillery = AIsaveto.ANEArtillery;
            GameObject.Find("austria_nw").GetComponent<Control>().controller = AIsaveto.ANWcontroller;
            GameObject.Find("austria_nw").GetComponent<Control>().cavalry = AIsaveto.ANWCavalry;
            GameObject.Find("austria_nw").GetComponent<Control>().infantry = AIsaveto.ANWInfantry;
            GameObject.Find("austria_nw").GetComponent<Control>().artillery = AIsaveto.ANWArtillery;
            GameObject.Find("austria_se").GetComponent<Control>().controller = AIsaveto.ASEcontroller;
            GameObject.Find("austria_se").GetComponent<Control>().cavalry = AIsaveto.ASECavalry;
            GameObject.Find("austria_se").GetComponent<Control>().infantry = AIsaveto.ASEInfantry;
            GameObject.Find("austria_se").GetComponent<Control>().artillery = AIsaveto.ASEArtillery;
            GameObject.Find("austria_sw").GetComponent<Control>().controller = AIsaveto.ASWcontroller;
            GameObject.Find("austria_sw").GetComponent<Control>().cavalry = AIsaveto.ASWCavalry;
            GameObject.Find("austria_sw").GetComponent<Control>().infantry = AIsaveto.ASWInfantry;
            GameObject.Find("austria_sw").GetComponent<Control>().artillery = AIsaveto.ASWArtillery;
            GameObject.Find("greece_n").GetComponent<Control>().controller = AIsaveto.GNcontroller;
            GameObject.Find("greece_n").GetComponent<Control>().cavalry = AIsaveto.GNCavalry;
            GameObject.Find("greece_n").GetComponent<Control>().infantry = AIsaveto.GNInfantry;
            GameObject.Find("greece_n").GetComponent<Control>().artillery = AIsaveto.GNArtillery;
            GameObject.Find("greece_s").GetComponent<Control>().controller = AIsaveto.GScontroller;
            GameObject.Find("greece_s").GetComponent<Control>().cavalry = AIsaveto.GSCavalry;
            GameObject.Find("greece_s").GetComponent<Control>().infantry = AIsaveto.GSInfantry;
            GameObject.Find("greece_s").GetComponent<Control>().artillery = AIsaveto.GSArtillery;
            GameObject.Find("ottoman_e").GetComponent<Control>().controller = AIsaveto.OEcontroller;
            GameObject.Find("ottoman_e").GetComponent<Control>().cavalry = AIsaveto.OECavalry;
            GameObject.Find("ottoman_e").GetComponent<Control>().infantry = AIsaveto.OEInfantry;
            GameObject.Find("ottoman_e").GetComponent<Control>().artillery = AIsaveto.OEArtillery;
            GameObject.Find("ottoman_s").GetComponent<Control>().controller = AIsaveto.OScontroller;
            GameObject.Find("ottoman_s").GetComponent<Control>().cavalry = AIsaveto.OSCavalry;
            GameObject.Find("ottoman_s").GetComponent<Control>().infantry = AIsaveto.OSInfantry;
            GameObject.Find("ottoman_s").GetComponent<Control>().artillery = AIsaveto.OSArtillery;
            GameObject.Find("ottoman_w").GetComponent<Control>().controller = AIsaveto.OWcontroller;
            GameObject.Find("ottoman_w").GetComponent<Control>().cavalry = AIsaveto.OWCavalry;
            GameObject.Find("ottoman_w").GetComponent<Control>().infantry = AIsaveto.OWInfantry;
            GameObject.Find("ottoman_w").GetComponent<Control>().artillery = AIsaveto.OWArtillery;
            GameObject.Find("monte").GetComponent<Control>().controller = AIsaveto.MOcontroller;
            GameObject.Find("monte").GetComponent<Control>().cavalry = AIsaveto.MOCavalry;
            GameObject.Find("monte").GetComponent<Control>().infantry = AIsaveto.MOInfantry;
            GameObject.Find("monte").GetComponent<Control>().artillery = AIsaveto.MOArtillery;
            GameObject.Find("prussia_c").GetComponent<Control>().controller = AIsaveto.PRCcontroller;
            GameObject.Find("prussia_c").GetComponent<Control>().cavalry = AIsaveto.PRCCavalry;
            GameObject.Find("prussia_c").GetComponent<Control>().infantry = AIsaveto.PRCInfantry;
            GameObject.Find("prussia_c").GetComponent<Control>().artillery = AIsaveto.PRCArtillery;
            GameObject.Find("prussia_e").GetComponent<Control>().controller = AIsaveto.PREcontroller;
            GameObject.Find("prussia_e").GetComponent<Control>().cavalry = AIsaveto.PRECavalry;
            GameObject.Find("prussia_e").GetComponent<Control>().infantry = AIsaveto.PREInfantry;
            GameObject.Find("prussia_e").GetComponent<Control>().artillery = AIsaveto.PREArtillery;
            GameObject.Find("prussia_w").GetComponent<Control>().controller = AIsaveto.PRWcontroller;
            GameObject.Find("prussia_w").GetComponent<Control>().cavalry = AIsaveto.PRWCavalry;
            GameObject.Find("prussia_w").GetComponent<Control>().infantry = AIsaveto.PRWInfantry;
            GameObject.Find("prussia_w").GetComponent<Control>().artillery = AIsaveto.PRWArtillery;
            GameObject.Find("warsaw_n").GetComponent<Control>().controller = AIsaveto.WWNcontroller;
            GameObject.Find("warsaw_n").GetComponent<Control>().cavalry = AIsaveto.WWNCavalry;
            GameObject.Find("warsaw_n").GetComponent<Control>().infantry = AIsaveto.WWNInfantry;
            GameObject.Find("warsaw_n").GetComponent<Control>().artillery = AIsaveto.WWNArtillery;
            GameObject.Find("warsaw_s").GetComponent<Control>().controller = AIsaveto.WWScontroller;
            GameObject.Find("warsaw_s").GetComponent<Control>().cavalry = AIsaveto.WWSCavalry;
            GameObject.Find("warsaw_s").GetComponent<Control>().infantry = AIsaveto.WWSInfantry;
            GameObject.Find("warsaw_s").GetComponent<Control>().artillery = AIsaveto.WWSArtillery;
            GameObject.Find("warsaw_w").GetComponent<Control>().controller = AIsaveto.WWWcontroller;
            GameObject.Find("warsaw_w").GetComponent<Control>().cavalry = AIsaveto.WWWCavalry;
            GameObject.Find("warsaw_w").GetComponent<Control>().infantry = AIsaveto.WWWInfantry;
            GameObject.Find("warsaw_w").GetComponent<Control>().artillery = AIsaveto.WWWArtillery;
            GameObject.Find("russia_n").GetComponent<Control>().controller = AIsaveto.RUNcontroller;
            GameObject.Find("russia_n").GetComponent<Control>().cavalry = AIsaveto.RUNCavalry;
            GameObject.Find("russia_n").GetComponent<Control>().infantry = AIsaveto.RUNInfantry;
            GameObject.Find("russia_n").GetComponent<Control>().artillery = AIsaveto.RUNArtillery;
            GameObject.Find("russia_c").GetComponent<Control>().controller = AIsaveto.RUCcontroller;
            GameObject.Find("russia_c").GetComponent<Control>().cavalry = AIsaveto.RUCCavalry;
            GameObject.Find("russia_c").GetComponent<Control>().infantry = AIsaveto.RUCInfantry;
            GameObject.Find("russia_c").GetComponent<Control>().artillery = AIsaveto.RUCArtillery;
            GameObject.Find("russia_s").GetComponent<Control>().controller = AIsaveto.RUScontroller;
            GameObject.Find("russia_s").GetComponent<Control>().cavalry = AIsaveto.RUSCavalry;
            GameObject.Find("russia_s").GetComponent<Control>().infantry = AIsaveto.RUSInfantry;
            GameObject.Find("russia_s").GetComponent<Control>().artillery = AIsaveto.RUSArtillery;
            GameObject.Find("sweden_n").GetComponent<Control>().controller = AIsaveto.SWNcontroller;
            GameObject.Find("sweden_n").GetComponent<Control>().cavalry = AIsaveto.SWNCavalry;
            GameObject.Find("sweden_n").GetComponent<Control>().infantry = AIsaveto.SWNInfantry;
            GameObject.Find("sweden_n").GetComponent<Control>().artillery = AIsaveto.SWNArtillery;
            GameObject.Find("sweden_c").GetComponent<Control>().controller = AIsaveto.SWCcontroller;
            GameObject.Find("sweden_c").GetComponent<Control>().cavalry = AIsaveto.SWCCavalry;
            GameObject.Find("sweden_c").GetComponent<Control>().infantry = AIsaveto.SWCInfantry;
            GameObject.Find("sweden_c").GetComponent<Control>().artillery = AIsaveto.SWCArtillery;
            GameObject.Find("sweden_s").GetComponent<Control>().controller = AIsaveto.SWScontroller;
            GameObject.Find("sweden_s").GetComponent<Control>().cavalry = AIsaveto.SWSCavalry;
            GameObject.Find("sweden_s").GetComponent<Control>().infantry = AIsaveto.SWSInfantry;
            GameObject.Find("sweden_s").GetComponent<Control>().artillery = AIsaveto.SWSArtillery;
            GameObject.Find("denmark_n").GetComponent<Control>().controller = AIsaveto.DKNcontroller;
            GameObject.Find("denmark_n").GetComponent<Control>().cavalry = AIsaveto.DKNCavalry;
            GameObject.Find("denmark_n").GetComponent<Control>().infantry = AIsaveto.DKNInfantry;
            GameObject.Find("denmark_n").GetComponent<Control>().artillery = AIsaveto.DKNArtillery;
            GameObject.Find("denmark_s").GetComponent<Control>().controller = AIsaveto.DKScontroller;
            GameObject.Find("denmark_s").GetComponent<Control>().cavalry = AIsaveto.DKSCavalry;
            GameObject.Find("denmark_s").GetComponent<Control>().infantry = AIsaveto.DKSInfantry;
            GameObject.Find("denmark_s").GetComponent<Control>().artillery = AIsaveto.DKSArtillery;
            GameObject.Find("norway_e").GetComponent<Control>().controller = AIsaveto.NYEcontroller;
            GameObject.Find("norway_e").GetComponent<Control>().cavalry = AIsaveto.NYECavalry;
            GameObject.Find("norway_e").GetComponent<Control>().infantry = AIsaveto.NYEInfantry;
            GameObject.Find("norway_e").GetComponent<Control>().artillery = AIsaveto.NYEArtillery;
            GameObject.Find("norway_w").GetComponent<Control>().controller = AIsaveto.NYWcontroller;
            GameObject.Find("norway_w").GetComponent<Control>().cavalry = AIsaveto.NYWCavalry;
            GameObject.Find("norway_w").GetComponent<Control>().infantry = AIsaveto.NYWInfantry;
            GameObject.Find("norway_w").GetComponent<Control>().artillery = AIsaveto.NYWArtillery;
        }
    }
}