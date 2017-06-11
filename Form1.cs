using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace millionaire1
{
    public partial class Form1 : Form
    {           
        int mil = 0;
        public Form1()
        {
            InitializeComponent();
            
        }      
       private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;

            radioButton1.BackColor = Color.Black;
            radioButton2.BackColor = Color.Black;
            radioButton3.BackColor = Color.Black;
            radioButton4.BackColor = Color.Black;                                            
           
            SoundPlayer hb = new SoundPlayer(@"C:\Users\Andreadi-s\Downloads\heartbeat-03.wav");
            hb.Play();

            chart1.Visible = false;
            //Εκκίνηση του χρονομέτρου με τη μορφή progrressbar!!
            timer1.Start();
            progressBar1.Value = 0;

            mil = mil + 1;
             {
                switch(mil)
                {
                    case 1:
                        erwtisi1();
                        mil = 1;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 2:
                        erwtisi2();
                        mil = 2;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 3:
                        erwtisi3();
                        mil = 3;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 4:
                        erwtisi4();
                        mil = 4;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 5:
                        erwtisi5();
                        mil = 5;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 6:
                        erwtisi6();
                        mil = 6;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 7:
                        erwtisi7();
                        mil = 7;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 8:
                        erwtisi8();
                        mil = 8;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 9:
                        erwtisi9();
                        mil = 9;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 10:
                        erwtisi10();
                        mil = 10;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 11:
                        erwtisi11();
                        mil = 11;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 12:
                        erwtisi12();
                        mil = 12;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 13:
                        erwtisi13();
                        mil = 13;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 14:
                        erwtisi14();
                        mil = 14;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 15:
                        erwtisi15();
                        mil = 15;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 16:
                        erwtisi16();
                        mil = 16;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 17:
                        erwtisi17();
                        mil = 17;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 18:
                        erwtisi18();
                        mil = 18;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 19:
                        erwtisi19();
                        mil = 19;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 20:
                        erwtisi20();
                        mil = 20;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 21:
                        erwtisi21();
                        mil = 21;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 22:
                        erwtisi22();
                        mil = 22;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 23:
                        erwtisi23();
                        mil = 23;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 24:
                        erwtisi24();
                        mil = 24;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 25:
                        erwtisi25();
                        mil = 25;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 26:
                        erwtisi26();
                        mil = 26;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 27:
                        erwtisi27();
                        mil = 27;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 28:
                        erwtisi28();
                        mil = 28;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 29:
                        erwtisi29();
                        mil = 29;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                    case 30:
                        erwtisi30();
                        mil = 30;
                        button1.Text = Convert.ToString(mil);
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        button1.Enabled = true;
                        break;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'millionaireDataSet.players' table. You can move, or remove it, as needed.
          
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            button1.Text = "Παίξε!";
            SoundPlayer player1 = new SoundPlayer(@"C:\Users\Andreadi-s\Music\Who Wants To Be A Millionaire Full Theme.wav");
            player1.Play();            
            pictureBox4.Visible = false;
            chart1.Visible = false;               
        }

        private void erwtisi1()
        {
            label1.Text = "Τι σημαίνει η λέξη 'Φερέγγυος'; ";
            radioButton1.Text = "A: υποφερτός";
            radioButton2.Text = "B: καταφερτζής";
            radioButton3.Text = "Γ: αξιόπιστος";
            radioButton4.Text = "Δ: επικίνδυνος";
        }
        private void erwtisi2()
        {
            label1.Text = "Πως λεγόταν ο γιος του πολυμήχανου Οδυσσέα;";
            radioButton1.Text = "Α: Πάτροκλος";
            radioButton2.Text = "Β:Τηλέμαχος";
            radioButton3.Text = "Γ: Πολύφημος";
            radioButton4.Text = "Δ: Έκτορας";
        }
        private void erwtisi3()
        {
            label1.Text = "Ποια είναι η πρωτεύουσα των δωδεκανήσων;";
            radioButton1.Text = "A: Κάρπαθος";
            radioButton2.Text = "B: Πάτμος";
            radioButton3.Text = "Γ: Ρόδος";
            radioButton4.Text = "Δ: Κως";
        }
        private void erwtisi4()
        {
            label1.Text = "Ποιό από τα ζώδια είναι το πρώτο στο ζωδιακό κύκλο;";
            radioButton1.Text = "Α: Λέων";
            radioButton2.Text = "Β: Σκορπιός";
            radioButton3.Text = "Γ: Ταύρος";
            radioButton4.Text = "Δ: Κριός";
        }
        private void erwtisi5()
        {
            label1.Text = "Ποιά χρονολογία κυκλοφόρησε το τραγούδι «Δυνατά-Δυνατά» της Ελευθερίας Αρβανητάκη;";
            radioButton1.Text = "Α: 2007";
            radioButton2.Text = "Β: 1998";
            radioButton3.Text = "Γ: 2001";
            radioButton4.Text = "Δ: 2004";
        }
        private void erwtisi6()
        {
            label1.Text = "Από τι υλικό κατασκευάζεται η οπτική ίνα;";
            radioButton1.Text = "Α: Από γυαλί";
            radioButton2.Text = "Β: Από πλαστικό";
            radioButton3.Text = "Γ: Από χαλκό";
            radioButton4.Text = "Δ: Α και Β";
        }
        private void erwtisi7()
          {
            label1.Text = "Πότε έγινε η επίσημη έναρξη της κρατικής τηλεόρασης στην Ελλάδα; ";
            radioButton1.Text = "Α: 1951";
            radioButton2.Text = "Β: 1966";
            radioButton3.Text = "Γ: 1970";
            radioButton4.Text = "Δ: 1968";
        }
        private void erwtisi8()
        {
            label1.Text = "Που βρίσκεται ο ποταμός νείλος;";
            radioButton1.Text = "Α: Στην Αίγυπτο";
            radioButton2.Text = "Β: Στην Ουγκάντα";
            radioButton3.Text = "Γ: Στην Αφρική";
            radioButton4.Text = "Δ: Στο Νότιο Σουδάν";
        }
        private void erwtisi9()
        {
            label1.Text = "Ποιό από τα παρακάτω έχει τη μεγαλύτερη θερμοχωρητικότητα;";
            radioButton1.Text = "A: Δέντρο";
            radioButton2.Text = "Β: άμμος";
            radioButton3.Text = "Γ: σίδερο";
            radioButton4.Text = "Δ: νερό";
        }
        private void erwtisi10()
        {
            label1.Text = "Ποιός θεωρείται ο θεμελιωτής της «λογικής»;";
            radioButton1.Text = "Α: Ο Αριστοτέλης";
            radioButton2.Text = "Β: Ο Πυθαγόρας";
            radioButton3.Text = "Γ: Ο Ηράκλειτος";
            radioButton4.Text = "Δ: Ο Θουκυδίδης";
        }
        private void erwtisi11()
        {
            label1.Text = "Σε ποιο φαινόμενο οφείλεται το «Βόρειο Σέλας;»";
            radioButton1.Text = "Α: Της Επαγωγής";
            radioButton2.Text = "Β: Της Αυτεπαγωγής";
            radioButton3.Text = "Γ: Της Μαγνητικής Φιάλης";
            radioButton4.Text = "Δ: Της Αμοιβαίας Επαγωγής";
        }
        private void erwtisi12()
        {
            label1.Text = "«Πατρίκιοι» ήταν οι Ρωμαίοι που ανήκαν: ";
            radioButton1.Text = "Α: Στις παλαιές μεγάλες οικογένειες";
            radioButton2.Text = "Β: Στους νεότερους κάτοικου της Ρώμης";
            radioButton3.Text = "Γ: Στους άρχοντες που εκλέγονταν για ένα χρόνο";
            radioButton4.Text = "Δ: Στους εκπροσώπους της εκτελεστικής εξουσίας";
        }
        private void erwtisi13()
        {
            label1.Text = "Τα Μικρά ή Κατ' αγρούς Διονύσια τελούνταν:";
            radioButton1.Text = "Α: Τον αττικό μήνα";
            radioButton2.Text = "Β: Το μήνα Ποσειδεώνα";
            radioButton3.Text = "Γ: Το μήνα Ανθεστηριώνα";
            radioButton4.Text = "Δ: Το μήνα Γαμηλιώνα";
        }
        private void erwtisi14()
        {
            label1.Text = "Τα οστά είναι όργανα που αποτελούνται από:";
            radioButton1.Text = "Α: Μεσοκυττάρια ουσία";
            radioButton2.Text = "Β: Οστίτη ιστό";
            radioButton3.Text = "Γ: Οστεοκύτταρα";
            radioButton4.Text = "Δ: Α και Γ";
        }
        private void erwtisi15()
        {
            label1.Text = "Η μετατροπή της ανενεργής ορμόνης του θυροειδή Τ4 σε ενεργή Τ3 απαιτεί: ";
            radioButton1.Text = "Α: Βιταμίνες A και D";
            radioButton2.Text = "Β: Ψευδάργυρο";
            radioButton3.Text = "Γ: Ω3-λιπαρά οξέα";
            radioButton4.Text = "Δ: Σελήνιο";
        }
        private void erwtisi16()
        {
            label1.Text = "Το χρώμα του ουρανού είναι μπλε γιατί..";
            radioButton1.Text = "A: Τα μόρια του αέρα είναι μπλε";
            radioButton2.Text = "Β: Η ίριδα των ματιών μας είναι μπλε";
            radioButton3.Text = "Γ: Η σκέδαση του φωτός είναι εντονότερη σε μικρά μήκη κύματος";
            radioButton4.Text = "Δ: Η σκέδαση του φωτός είναι εντονότερη σε μεγάλα μήκη κύματος";
        }
        private void erwtisi17()
        {
            label1.Text = "Στις σχέσεις που περιγράφουν το φαινόμενο Doppler οι ταχύτητες αναφέρονται..";
            radioButton1.Text = "A: στο σύστημα αναφοράς της πηγής";
            radioButton2.Text = "Β: στο σύστημα αναφοράς του παρατηρητή";
            radioButton3.Text = "Γ: στο σύστημα αναφοράς του μέσου διάδοσης";
            radioButton4.Text = "Δ: Όλα τα παραπάνω";
        }
        private void erwtisi18()
        {
            label1.Text = "Ποιά είναι η πατρίδα της μπίρας Χάινεκεν;";
            radioButton1.Text = "A: Γαλλία";
            radioButton2.Text = "Β: Αυστρία";
            radioButton3.Text = "Γ: Γερμανία";
            radioButton4.Text = "Δ: Ολανδία";
        }
        private void erwtisi19()
        {
            label1.Text = "Ποιό πρώην στέλεχος του ΠΑΣΟΚ έγραφε ερωτήσεις για τηλεπαιχνίδι;";
            radioButton1.Text = "A: Βαγγέλης Χωραφάς";
            radioButton2.Text = "Β: Αλέξης Μητρόπουλος";
            radioButton3.Text = "Γ: Θανάσης Χειμωνάς";
            radioButton4.Text = "Δ: Μάρκος Μπόλαρης";
        }
        private void erwtisi20()
        {
            label1.Text = "Πόσο ψηλότερος είναι ένας ενήλικας το πρωί που ξυπνάει;";
            radioButton1.Text = "A: 1cm";
            radioButton2.Text = "Β: 5mm";
            radioButton3.Text = "Γ: 8mm";
            radioButton4.Text = "Δ: 2cm";
        }
        private void erwtisi21()
        {
            label1.Text = "Πώς λεγόταν η παρουσιάστρια του τηλεπαιχνιδιού « Μπράβο Χάσατε »;";
            radioButton1.Text = "A: Πωλίνα";
            radioButton2.Text = "Β: Βύκη Σταυροπούλου";
            radioButton3.Text = "Γ: Βάσια Τριφύλλη";
            radioButton4.Text = "Δ: Γιολαντα Διαμαντή";
        }

        private void erwtisi22()
        {
            label1.Text = "Πώς ονομάζεται η ορμόνη που ρυθμίζει το μεταβολισμό;";
            radioButton1.Text = "A: Κορτιζόλη";
            radioButton2.Text = "Β: Λεπτίνη";
            radioButton3.Text = "Γ: Αδρεναλίνη";
            radioButton4.Text = "Δ: Θυροξίνη";
        }
        private void erwtisi23()
        {
            label1.Text = "Ποιά χώρα ήταν νικήτρια στο διαγωνισμό της Eurovision 2007;";
            radioButton1.Text = "A: Αυστρία";
            radioButton2.Text = "Β: Ρωσία";
            radioButton3.Text = "Γ: Αζερμπαϊτζάν";
            radioButton4.Text = "Δ: Ελλάδα";
        }

        private void erwtisi24()
        {
            label1.Text = "Ποιό από τα παρακάτω είναι πλεονεκτήματα του τμηματικού προγραμματισμού;";
            radioButton1.Text = "A: Λιγότερος χρόνος ανάπτυξης προγράμματος";
            radioButton2.Text = "Β: Ευκολότερη διόρθωση";
            radioButton3.Text = "Γ: Ταχύτητα κατά την εκτέλεση";
            radioButton4.Text = "Δ: Το Α και το Β";
        }
        private void erwtisi25()
        {
            label1.Text = "Πώς ονομάζεται η πρωτεΐνη του ΩΜΟΥ αβγού;";
            radioButton1.Text = "A: Αλβουμίνη";
            radioButton2.Text = "Β: Καζεΐνη";
            radioButton3.Text = "Γ: Γλουτένιο";
            radioButton4.Text = "Δ: Βιοτίνη";
        }

        private void erwtisi26()
        {
            label1.Text = "Ποιό είναι το τελευταίο, αλφαβητικά, κράτος της Ασίας;";
            radioButton1.Text = "A: Κατάρ";
            radioButton2.Text = "Β: Ταϊλανδη";
            radioButton3.Text = "Γ: Φιλιππίνες";
            radioButton4.Text = "Δ: Μπαχρέιν";
        }
        private void erwtisi27()
        {
            label1.Text = "Η βαθύτερη λίμνη στον κόσμο είναι...";
            radioButton1.Text = "A: Κασπία";
            radioButton2.Text = "Β: Βαϊκάλη";
            radioButton3.Text = "Γ: Τιτικάκα";
            radioButton4.Text = "Δ: Καμία από αυτές";
        }

        private void erwtisi28()
        {
            label1.Text = "Η Πόλη Τομπουκτού Βρισκεται...";
            radioButton1.Text = "A: στο Μάλι";
            radioButton2.Text = "Β: στην Γκανά";
            radioButton3.Text = "Γ: στη Μαυριτανία";
            radioButton4.Text = "Δ: στο Λίβανο";
        }
        private void erwtisi29()
        {
            label1.Text = "Το Σινικό τοίχος έχει μήκος περίπου...;";
            radioButton1.Text = "A: 5000km";
            radioButton2.Text = "Β: 4000km";
            radioButton3.Text = "Γ: 3000km";
            radioButton4.Text = "Δ: 2000km";
        }
        private void erwtisi30()
        {
            label1.Text = "Ένας Αλσατός είναι...;";
            radioButton1.Text = "A: Γάλλος";
            radioButton2.Text = "Β: Ελβετός";
            radioButton3.Text = "Γ: Γερμανός";
            radioButton4.Text = "Δ: Λιθουανός";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {  //Σταματάει ο ήχος της φόρμας
           SoundPlayer player1 = new SoundPlayer(@"C:\Users\Andreadi-s\Music\Who Wants To Be A Millionaire Full Theme.wav");
           player1.Stop();
            //Σταματάει η Progressbar
            timer1.Stop();
            SoundPlayer hb = new SoundPlayer(@"C:\Users\Andreadi-s\Downloads\heartbeat-03.wav");
            hb.Stop();
            //Σωστές απαντήσεις
            if (button1.Text=="5")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton1.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[4];

            }
            if(button1.Text=="10")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();
                radioButton1.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[9];
                
            }
            if(button1.Text=="12")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();
                radioButton1.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[11];
            }
            if(button1.Text=="21")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton1.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[4];
            }
            if(button1.Text=="25")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();
                radioButton1.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[8];
            }
            if (button1.Text == "28")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton1.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[11];
                
            }
            if(button1.Text=="30")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();
                radioButton1.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[14];
                pictureBox4.Visible = true;
            }
            //Λάθος απαντήσεις
            if (button1.Text == "1" || button1.Text == "2" || button1.Text == "3" || button1.Text == "4" || button1.Text == "6" || button1.Text == "11" ||
                 button1.Text == "13" || button1.Text == "15" || button1.Text == "16" || button1.Text == "17" || button1.Text == "18" || button1.Text == "19" ||
                 button1.Text == "20" || button1.Text == "22" || button1.Text == "23" || button1.Text == "24" || button1.Text == "26" || button1.Text == "27" || button1.Text == "9") 
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\fail-trombone-02.wav"));
                    a1.Play();
                }).Start();

                radioButton1.BackColor = Color.Red;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Λάθος!";
                button1.Enabled = true;
                
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {   //Σταματάει ο ήχος της φόρμας
            SoundPlayer player1 = new SoundPlayer(@"C:\Users\Andreadi-s\Music\Who Wants To Be A Millionaire Full Theme.wav");
            player1.Stop();

            //Σταματάει η progressbar
            timer1.Stop();
            SoundPlayer hb = new SoundPlayer(@"C:\Users\Andreadi-s\Downloads\heartbeat-03.wav");
            hb.Stop();

            //Σωστές απαντήσεις
            if (button1.Text=="2")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton2.BackColor = Color.Gold;
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[1];
                
            }
            if (button1.Text == "7")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton2.BackColor = Color.Gold;
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[6];
            }
            if (button1.Text == "13")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton2.BackColor = Color.Gold;
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[12];
            }
            if (button1.Text == "14")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton2.BackColor = Color.Gold;
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[13];
                
            }
            if (button1.Text == "17")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton2.BackColor = Color.Gold;
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[1];  
            
            }
            if (button1.Text == "23")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton2.BackColor = Color.Gold;
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[5];
            }
            if (button1.Text == "27")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();
                radioButton2.BackColor = Color.Gold;
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[10];
            }
            //Λάθος απαντήσεις
            if (button1.Text == "1" || button1.Text == "3" || button1.Text == "6" || button1.Text == "8" || button1.Text == "12" || button1.Text == "15" ||
               button1.Text == "16" || button1.Text == "18" || button1.Text == "19" || button1.Text == "21" || button1.Text == "22" || button1.Text == "24" ||
               button1.Text == "25" || button1.Text == "26" || button1.Text == "28" || button1.Text == "29" || button1.Text == "4" ||
               button1.Text == "5" || button1.Text == "9" || button1.Text == "10" || button1.Text == "11" || button1.Text == "12" || button1.Text=="20")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\fail-trombone-02.wav"));
                    a1.Play();
                }).Start();
                radioButton2.BackColor = Color.Red;
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Λάθος!";
                button1.Enabled = true;
            }
            if(button1.Text == "30")
            {                 
                SoundPlayer lose = new SoundPlayer(@"C:\Users\Andreadi-s\Music\lose.wav");
                lose.Play();
                radioButton2.BackColor = Color.Red;
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Λάθος!";
                button1.Enabled = true;
                
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {   //Σταματάει ο ήχος της φόρμας
            SoundPlayer player1 = new SoundPlayer(@"C:\Users\Andreadi-s\Music\Who Wants To Be A Millionaire Full Theme.wav");
            player1.Stop();

            SoundPlayer hb = new SoundPlayer(@"C:\Users\Andreadi-s\Downloads\heartbeat-03.wav");
            hb.Stop();
            //Σταματάει η Progressbar
            timer1.Stop();
            //Σωστές απαντήσεις
            if (button1.Text=="1")
            {
                 new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();              
                radioButton3.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[0];
            }
            if (button1.Text == "3")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton3.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[2];
            }
            if (button1.Text == "8")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();
                radioButton3.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[7];
                
            }
            if (button1.Text == "11")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();
                radioButton3.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[10];
            }
            if (button1.Text == "16")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton3.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[0];
                
            }
            if (button1.Text == "19")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();
                radioButton3.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[3];
            }
            if (button1.Text == "20")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();
                radioButton3.BackColor = Color.Gold;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[4];
               
            }
        if (button1.Text == "26")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton3.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[9];
                
            }
            if (button1.Text == "29")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();

                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton3.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[13];
            }
                //Λάθος απαντήσεις
                if (button1.Text == "2" || button1.Text == "4" || button1.Text == "5" || button1.Text == "6" || button1.Text == "7" || button1.Text == "9" ||
                   button1.Text == "10" || button1.Text == "12" || button1.Text == "13" || button1.Text == "14" || button1.Text == "15" || button1.Text == "17"||
                   button1.Text == "18" || button1.Text == "20" || button1.Text == "21" || button1.Text == "22" || button1.Text == "23" || button1.Text == "24" ||
                   button1.Text == "25" || button1.Text == "27" || button1.Text == "28" || button1.Text == "29")
                {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\fail-trombone-02.wav"));
                    a1.Play();
                }).Start();
                    radioButton3.BackColor = Color.Red;
                    radioButton2.Visible = false;
                    radioButton1.Visible = false;
                    radioButton4.Visible = false;
                    button1.Text = "Λάθος!";
                    button1.Enabled = true;
                }
                if(button1.Text=="30")
            {
                radioButton3.BackColor = Color.Red;
                SoundPlayer lose = new SoundPlayer(@"C:\Users\Andreadi-s\Music\lose.wav");
                lose.Play();
                radioButton3.BackColor = Color.Red;
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                button1.Text = "Λάθος!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[4];
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {   //Σταματάει ο ήχος της φόρμας
            SoundPlayer player1 = new SoundPlayer(@"C:\Users\Andreadi-s\Music\Who Wants To Be A Millionaire Full Theme.wav");
            player1.Stop();
            SoundPlayer hb = new SoundPlayer(@"C:\Users\Andreadi-s\Downloads\heartbeat-03.wav");
            hb.Stop();
            //Σταματάει η progressbar
            timer1.Stop();

            //Σωστές απαντήσεις
            if (button1.Text=="4")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();
                radioButton4.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[3];
                
            }
            if (button1.Text == "6")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton4.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[5];
                
            }
            if (button1.Text == "9")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton4.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[8];
            }
            if (button1.Text == "14")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();
                radioButton4.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[13];
            }
            if (button1.Text == "15")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton4.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox4.Image = imageList1.Images[14];
            }
            if (button1.Text == "18")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton4.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[2];
               
            }
            if (button1.Text == "22")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton4.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[5];
                
            }
            if (button1.Text == "24")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\Ta Da-SoundBible.com-1884170640.wav"));
                    a1.Play();
                }).Start();

                radioButton4.BackColor = Color.Gold;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
                button1.Text = "Σωστά!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[6];
                
            }
            //Λάθος απαντήσεις
            if(button1.Text=="1" || button1.Text == "2" || button1.Text == "3" || button1.Text == "5" || button1.Text == "7" || button1.Text == "8" ||
                button1.Text == "10" || button1.Text == "11" || button1.Text == "12" || button1.Text == "13" || button1.Text == "16" || button1.Text == "17" ||
                button1.Text == "19" || button1.Text == "20" || button1.Text == "21" || button1.Text == "23" || button1.Text == "25" || button1.Text == "26" ||
                button1.Text == "27" || button1.Text == "28" || button1.Text == "29")
            {
                new System.Threading.Thread(() =>
                {
                    var a = new System.Windows.Media.MediaPlayer();
                    a.Open(new System.Uri(@"C:\Users\Andreadi-s\Music\suspense1.wav"));
                    a.Play();
                }).Start();
                System.Threading.Thread.Sleep(6000);
                new System.Threading.Thread(() =>
                {
                    var a1 = new System.Windows.Media.MediaPlayer();
                    a1.Open(new System.Uri(@"C:\Users\Andreadi-s\Downloads\fail-trombone-02.wav"));
                    a1.Play();
                }).Start();

                radioButton4.BackColor = Color.Red;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
                button1.Text = "Λάθος!";
                button1.Enabled = true;
            }
            if(button1.Text=="30")
            {                
                SoundPlayer lose = new SoundPlayer(@"C:\Users\Andreadi-s\Music\lose.wav");
                lose.Play();
                radioButton4.BackColor = Color.Red;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
                button1.Text = "Λάθος!";
                button1.Enabled = true;
                pictureBox1.Image = imageList1.Images[4];
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {  //Βοήθεια απαντήσεων
            SoundPlayer voitheia = new SoundPlayer(@"C:\Users\Andreadi-s\Downloads\button-1.wav");
            voitheia.Play();
            if(button1.Text=="Λάθος")
            {
                pictureBox2.Image = imageList1.Images[16];
            }
            else
            {
                pictureBox2.Image = imageList1.Images[15];
            }
            if(button1.Text=="1"|| button1.Text == "8" || button1.Text == "11")
            {
                radioButton2.Visible = false;
                radioButton4.Visible = false;
                pictureBox2.Enabled = false;
            }
            if(button1.Text=="2"|| button1.Text == "3" || button1.Text == "4" || button1.Text == "6"|| button1.Text == "16"||
                button1.Text == "24" || button1.Text == "29")
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                pictureBox2.Enabled = false;
            }           
            if(button1.Text=="5" || button1.Text == "9"|| button1.Text == "17"|| button1.Text == "19"|| button1.Text == "25" || button1.Text == "30")
            {
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                pictureBox2.Enabled = false;
            }          
            if(button1.Text=="7"|| button1.Text == "10" || button1.Text == "12" || button1.Text == "21"|| button1.Text == "27" ||
                button1.Text == "28")
            {
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                pictureBox2.Enabled = false;
            }
            if (button1.Text == "13" || button1.Text == "14"|| button1.Text == "20"|| button1.Text == "26")
            {
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                pictureBox2.Enabled = false;
            }
            if (button1.Text == "15" || button1.Text == "18"|| button1.Text == "22"|| button1.Text == "23")
            {
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                pictureBox2.Enabled = false;
            }                       
                                    
         }
        private void pictureBox3_Click(object sender, EventArgs e)
        {  //Βοήθεια του κοινού          
            SoundPlayer voitheia = new SoundPlayer(@"C:\Users\Andreadi-s\Downloads\button-1.wav");
            voitheia.Play();          
               
                //Εμφάνιση διαγράμματος
                chart1.Visible = true;
                this.chart1.Series["people"].Points.AddXY("A", 30);
                this.chart1.Series["people"].Points.AddXY("B", 20);
                this.chart1.Series["people"].Points.AddXY("Γ", 40);
                this.chart1.Series["people"].Points.AddXY("Δ", 10);
                pictureBox3.Image = imageList1.Images[18];
        }
        private void button2_Click(object sender, EventArgs e)
        {  //Γίνεται επανεκκίνηση της εφαρμογής
            Application.Restart();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 300;
          
            if (progressBar1.Value<=100)
            {
                progressBar1.Value = progressBar1.Value+10/10;
            }
            if(progressBar1.Value==100)
            {
                MessageBox.Show("Τέλος χρόνου");
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }
            
          }
        private void button3_Click(object sender, EventArgs e)
        {           
           panel1.Visible = false;                       
         }         
        private void button5_Click(object sender, EventArgs e)
        {   
            //Έξοδος από την εφαρμογή
            Application.Exit();
        }
        private void chart1_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Καλώς ήρθατε στο παιχνίδι «Millionaire» !!" +
               "Οι κανόνες του έχουν ως εξής: Πατώντας το κουμπί 'παίξε' " +
               "εμφανίζονται οι ερωτήσεις, συνοδευόμενες από τις 4 πιθανές απαντήσεις!" +               
               "Έχετε μια βοήθεια κοινού και μια βοήθεια απαντήσεων. Με το κουμπί 'Restart'" +
               "γίνεται επανεκκίνηση της φόρμας." +
               "ΚΑΛΗ ΔΙΑΣΚΕΔΑΣΗ!!");
            }
        private void chart1_Click_1(object sender, EventArgs e)
        {            
        }
    }
}
