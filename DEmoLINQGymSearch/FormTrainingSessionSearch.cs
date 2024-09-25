using DEmoLINQGymSearch.Classes.cs;

namespace DEmoLINQGymSearch
{
    public partial class FormTrainingSessionSearch : Form
    {
        public FormTrainingSessionSearch()
        {
            InitializeComponent();

            comboBoxSelection.Items.Add("Instruktor");
            comboBoxSelection.Items.Add("passtyp");

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //hämta 4 värde som användaren har satt som 
            //sökvilkor
            string type = comboBoxSelection.Text;

            string condition = textBoxSearchCondition.Text;

            DateTime start = dateTimePickerStart.Value;

            DateTime end = dateTimePickerEnd.Value;

            // sedan skikar vi dessa vidare för att göra sökningar

            //Loopar igenom resultat(Listan) och visar i listboxen
            //
            List<TrainingSession> result = TrainingSession.Search
          (type, condition, start, end);



            listBoxResult.Items.Clear();

            foreach (TrainingSession session in result)
            {

                listBoxResult.Items.Add($"{session.Trainer.Name})" +
                $"{session.Type.Name} {session.StartTime} {session.EndTime}");


            }
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
