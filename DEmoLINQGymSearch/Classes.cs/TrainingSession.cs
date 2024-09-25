

namespace DEmoLINQGymSearch.Classes.cs
{
    public class TrainingSession
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Instructor Trainer { get; set; }


        public TrainingSessionType Type { get; set; }


        public static List<TrainingSession> Search(string type
            , string condition, DateTime start, DateTime end)
        {
            List<TrainingSession> result = new();

            if (type == "Instruktor")
            {
                result = (from session in Repository.GetTrainingSessionData()

                          where session.Trainer.Name.Contains(condition)

                          && session.StartTime.Date >= start.Date
                          && session.EndTime.Date <= end.Date
                          select session

                    ).ToList();

            }
            else
            {

                result = (from session in Repository.GetTrainingSessionData()

                          where session.Type.Name.Contains(condition)

                          && session.StartTime.Date >= start.Date
                          && session.EndTime.Date <= end.Date
                          select session

                   ).ToList();


            }
            return result;

        }

      
}}
