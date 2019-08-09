using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    static List<int> numeriGiocata = new List<int>();
    static List<int> numeriEstratti = new List<int>();
    static bool giocataFatta = false;
    static bool estrazioneFatta = false;
    static List<int> nazionale = new List<int>();
    static List<int> bari = new List<int>();
    static List<int> cagliari = new List<int>();
    static List<int> firenze = new List<int>();
    static List<int> genova = new List<int>();
    static List<int> milano = new List<int>();
    static List<int> napoli = new List<int>();
    static List<int> palermo = new List<int>();
    static List<int> roma = new List<int>();
    static List<int> torino = new List<int>();
    static List<int> venezia = new List<int>();
    static List<List<int>> tutteRuote = new List<List<int>>();
    Random numeroEstratto = new Random();
    static List<string> listaRuote = new List<string>();

    protected void Page_Load(object sender, EventArgs e)
    {

        GeneraTabellaNumeri();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void BTNgiocata_Click(object sender, EventArgs e)
    {
        //numeriGiocata.Clear();
        listaRuote.Clear();
        giocataFatta = true;
        string stringaGiocata = "";
        foreach (int n in numeriGiocata)
        {
            stringaGiocata += Convert.ToString(n) + " ";
        }
        RuoteGiocate();
        string str = "";
        foreach (string ruota in listaRuote)
            str += ruota + " ";
        LBLresponso.Text = "Hai giocato i numeri: " + stringaGiocata + "<br/>sulle ruote: " + str;

    }

    /// <summary>
    /// Effettua un'estrazione di 5 numeri su tutte le ruote
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void BTNestrazione_Click(object sender, EventArgs e)
    {
        nazionale.Clear();
        bari.Clear();
        cagliari.Clear();
        firenze.Clear();
        genova.Clear();
        milano.Clear();
        napoli.Clear();
        palermo.Clear();
        roma.Clear();
        torino.Clear();
        venezia.Clear();

        estraiUnaRuota(nazionale);
        EstrazioneSuRuota("Nazionale", nazionale);
        estraiUnaRuota(bari);
        EstrazioneSuRuota("Bari", bari);
        estraiUnaRuota(cagliari);
        EstrazioneSuRuota("Cagliari", cagliari);
        estraiUnaRuota(firenze);
        EstrazioneSuRuota("Firenze", firenze);
        estraiUnaRuota(genova);
        EstrazioneSuRuota("Genova", genova);
        estraiUnaRuota(milano);
        EstrazioneSuRuota("Milano", milano);
        estraiUnaRuota(napoli);
        EstrazioneSuRuota("Napoli", napoli);
        estraiUnaRuota(palermo);
        EstrazioneSuRuota("Palermo", palermo);
        estraiUnaRuota(roma);
        EstrazioneSuRuota("Roma", roma);
        estraiUnaRuota(torino);
        EstrazioneSuRuota("Torino", torino);
        estraiUnaRuota(venezia);
        EstrazioneSuRuota("Venezia", venezia);
        tutteRuote.Add(nazionale);
        tutteRuote.Add(bari);
        tutteRuote.Add(cagliari);
        tutteRuote.Add(firenze);
        tutteRuote.Add(genova);
        tutteRuote.Add(milano);
        tutteRuote.Add(napoli);
        tutteRuote.Add(palermo);
        tutteRuote.Add(roma);
        tutteRuote.Add(torino);
        tutteRuote.Add(venezia);

        estrazioneFatta = true;
        ControllaGiocata();
    }

    /// <summary>
    /// Verifica se un numero estratto su una ruota è unico
    /// </summary>
    /// <param name="x"></param>
    /// <param name="listaNumeri"></param>
    /// <returns></returns>
    public bool IsValidNumber(int x, List<int> listaNumeri)
    {
        bool valido = false;

        if (!listaNumeri.Contains(x))
        {
            valido = true;
        }

        return valido;
    }

    /// <summary>
    /// Genera la tabella per la scelta dei numeri da giocare
    /// </summary>
    public void GeneraTabellaNumeri()
    {

        for (int i = 0; i <= 8; i++)
        {
            TableCell tc1 = new TableCell();
            TableCell tc2 = new TableCell();
            TableCell tc3 = new TableCell();
            TableCell tc4 = new TableCell();
            TableCell tc5 = new TableCell();
            TableCell tc6 = new TableCell();
            TableCell tc7 = new TableCell();
            TableCell tc8 = new TableCell();
            TableCell tc9 = new TableCell();
            TableCell tc10 = new TableCell();

            Button bt1 = new Button();
            Button bt2 = new Button();
            Button bt3 = new Button();
            Button bt4 = new Button();
            Button bt5 = new Button();
            Button bt6 = new Button();
            Button bt7 = new Button();
            Button bt8 = new Button();
            Button bt9 = new Button();
            Button bt10 = new Button();
            bt1.CssClass = "btn btn-outline-dark";/* d-flex justify-content-center*/
            bt2.CssClass = "btn btn-outline-dark";
            bt3.CssClass = "btn btn-outline-dark";
            bt4.CssClass = "btn btn-outline-dark";
            bt5.CssClass = "btn btn-outline-dark";
            bt6.CssClass = "btn btn-outline-dark";
            bt7.CssClass = "btn btn-outline-dark";
            bt8.CssClass = "btn btn-outline-dark";
            bt9.CssClass = "btn btn-outline-dark";
            bt10.CssClass = "btn btn-outline-dark";


            int numeroVariabile = i * 10;

            bt1.Text = Convert.ToString(1 + numeroVariabile);
            bt2.Text = Convert.ToString(2 + numeroVariabile);
            bt3.Text = Convert.ToString(3 + numeroVariabile);
            bt4.Text = Convert.ToString(4 + numeroVariabile);
            bt5.Text = Convert.ToString(5 + numeroVariabile);
            bt6.Text = Convert.ToString(6 + numeroVariabile);
            bt7.Text = Convert.ToString(7 + numeroVariabile);
            bt8.Text = Convert.ToString(8 + numeroVariabile);
            bt9.Text = Convert.ToString(9 + numeroVariabile);
            bt10.Text = Convert.ToString(10 + numeroVariabile);
            bt1.ID = bt1.Text;
            bt2.ID = bt2.Text;
            bt3.ID = bt3.Text;
            bt4.ID = bt4.Text;
            bt5.ID = bt5.Text;
            bt6.ID = bt6.Text;
            bt7.ID = bt7.Text;
            bt8.ID = bt8.Text;
            bt9.ID = bt9.Text;
            bt10.ID = bt10.Text;
            bt1.Click += new EventHandler(GiocaNumero);
            bt2.Click += new EventHandler(GiocaNumero);
            bt3.Click += new EventHandler(GiocaNumero);
            bt4.Click += new EventHandler(GiocaNumero);
            bt5.Click += new EventHandler(GiocaNumero);
            bt6.Click += new EventHandler(GiocaNumero);
            bt7.Click += new EventHandler(GiocaNumero);
            bt8.Click += new EventHandler(GiocaNumero);
            bt9.Click += new EventHandler(GiocaNumero);
            bt10.Click += new EventHandler(GiocaNumero);
            tc1.Controls.Add(bt1);
            tc2.Controls.Add(bt2);
            tc3.Controls.Add(bt3);
            tc4.Controls.Add(bt4);
            tc5.Controls.Add(bt5);
            tc6.Controls.Add(bt6);
            tc7.Controls.Add(bt7);
            tc8.Controls.Add(bt8);
            tc9.Controls.Add(bt9);
            tc10.Controls.Add(bt10);



            TableRow tr = new TableRow();
            tr.Cells.Add(tc1);
            tr.Cells.Add(tc2);
            tr.Cells.Add(tc3);
            tr.Cells.Add(tc4);
            tr.Cells.Add(tc5);
            tr.Cells.Add(tc6);
            tr.Cells.Add(tc7);
            tr.Cells.Add(tc8);
            tr.Cells.Add(tc9);
            tr.Cells.Add(tc10);


            TBLnumeri.Rows.Add(tr);

        }
    }

    /// <summary>
    /// Azione (richiamata dal click del bottone nella tabella dei numeri) che aggiunge o toglie un numero dalla lista dei numeri giocati
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void GiocaNumero(object sender, EventArgs e)
    {
        Button regeneratedbutton = (Button)sender;
        int id = Convert.ToInt32(regeneratedbutton.ID);
        if (!numeriGiocata.Contains(id))
        {
            regeneratedbutton.CssClass = "btn btn-primary";
            numeriGiocata.Add(id);
        }
        else
        {
            numeriGiocata.Remove(id);
            regeneratedbutton.CssClass = "btn btn-outline-dark";
        }
    }

    /// <summary>
    /// Genera la riga della tabella con i numeri estratti su una ruota specifica
    /// </summary>
    /// <param name="nomeRuota"></param>
    /// <param name="estrazioneRuota"></param>
    public void EstrazioneSuRuota(string nomeRuota, List<int> estrazioneRuota)

    {
        TableCell tc1 = new TableCell();
        TableCell tc2 = new TableCell();
        TableCell tc3 = new TableCell();
        TableCell tc4 = new TableCell();
        TableCell tc5 = new TableCell();
        TableCell tc6 = new TableCell();
        tc1.Text = nomeRuota;
        tc1.CssClass = "testoChiaro";
        tc2.Text = Convert.ToString(estrazioneRuota[0]);
        tc3.Text = Convert.ToString(estrazioneRuota[1]);
        tc4.Text = Convert.ToString(estrazioneRuota[2]);
        tc5.Text = Convert.ToString(estrazioneRuota[3]);
        tc6.Text = Convert.ToString(estrazioneRuota[4]);

        TableRow tr = new TableRow();
        tr.Cells.Add(tc1);
        tr.Cells.Add(tc2);
        tr.Cells.Add(tc3);
        tr.Cells.Add(tc4);
        tr.Cells.Add(tc5);
        tr.Cells.Add(tc6);


        TBLestrazione.Rows.Add(tr);
    }





    /// <summary>
    /// Estrae 5 numeri univoci e casuali su una determinata ruota e li inserisce nella lista della ruota 
    /// </summary>
    /// <param name="ruota"></param>
    public void estraiUnaRuota(List<int> ruota)
    {
        //Random numeroEstratto = new Random();
        int i = 0;
        while (i < 5)
        {
            int numero = numeroEstratto.Next(1, 91);
            if (IsValidNumber(numero, ruota))
            {
                ruota.Add(numero);
                i++;
            }
        }

    }

    /// <summary>
    /// Inserisce in una lista, l'elenco delle ruote selezionate in fase di giocata
    /// </summary>
    public void RuoteGiocate()
    {
        if (CHKbari.Checked)
        {
            listaRuote.Add("bari");
        }
        if (CHKcagliari.Checked)
        {
            listaRuote.Add("cagliari");
        }
        if (CHKfirenze.Checked)
        {
            listaRuote.Add("firenze");
        }
        if (CHKgenova.Checked)
        {
            listaRuote.Add("genova");
        }
        if (CHKmilano.Checked)
        {
            listaRuote.Add("milano");
        }
        if (CHKnapoli.Checked)
        {
            listaRuote.Add("napoli");
        }
        if (CHKnazionale.Checked)
        {
            listaRuote.Add("nazionale");
        }
        if (CHKpalermo.Checked)
        {
            listaRuote.Add("palermo");
        }
        if (CHKroma.Checked)
        {
            listaRuote.Add("roma");
        }
        if (CHKTorino.Checked)
        {
            listaRuote.Add("torino");
        }
        if (CHKvenezia.Checked)
        {
            listaRuote.Add("venezia");
        }
    }


    /// <summary>
    /// Verifica quanti, dei numeri della giocata, sono stati estratti su una determinata ruota e inserisce il risultato in una Label
    /// </summary>
    /// <param name="ruota"></param>
    /// <param name="giocata"></param>
    /// <param name="ruotaEstratta"></param>
    public void VerificaNumeriGiocatiSuRuota(string ruota, List<int> giocata, List<int> ruotaEstratta)
    {
        string result = "";
        int numeriIndovinati = 0;
        foreach (int numEstratto in ruotaEstratta)
        {
            foreach (int numGiocato in giocata)
                if (numGiocato == numEstratto)
                {
                    numeriIndovinati++;
                }
            result = "RUOTA: " + ruota + "    NUMERI INDOVINATI: " + numeriIndovinati + "<br>";

        }
        LBLrisultatoEstrazione.Text += result;
    }


    /// <summary>
    /// Per ogni ruota selezionata in fase di giocata, richiama la funzione VerificaNumeriGiocatiSuRuota
    /// </summary>
    public void ControllaGiocata()
    {
        foreach (string ruota in listaRuote)
        {
            switch (ruota)
            {
                case "bari":
                    VerificaNumeriGiocatiSuRuota("bari", numeriGiocata, bari);
                    break;
                case "cagliari":
                    VerificaNumeriGiocatiSuRuota("cagliari", numeriGiocata, cagliari);
                    break;
                case "firenze":
                    VerificaNumeriGiocatiSuRuota("firenze", numeriGiocata, firenze);
                    break;
                case "genova":
                    VerificaNumeriGiocatiSuRuota("genova", numeriGiocata, genova);
                    break;
                case "milano":
                    VerificaNumeriGiocatiSuRuota("milano", numeriGiocata, milano);
                    break;
                case "napoli":
                    VerificaNumeriGiocatiSuRuota("napoli", numeriGiocata, napoli);
                    break;
                case "nazionale":
                    VerificaNumeriGiocatiSuRuota("nazionale", numeriGiocata, nazionale);
                    break;
                case "palermo":
                    VerificaNumeriGiocatiSuRuota("palermo", numeriGiocata, palermo);
                    break;
                case "roma":
                    VerificaNumeriGiocatiSuRuota("roma", numeriGiocata, roma);
                    break;
                case "torino":
                    VerificaNumeriGiocatiSuRuota("torino", numeriGiocata, torino);
                    break;
                case "venezia":
                    VerificaNumeriGiocatiSuRuota("venezia", numeriGiocata, venezia);
                    break;
            }
        }
    }



}
