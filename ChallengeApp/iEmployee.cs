using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface iEmployee
    {
        string Name { get;}

        string Surname { get;}

        void AddPoints(float points);

        void AddPoints(double points);

        void AddPoints(char points);

        void AddPoints(long points);

        void AddPoints(int points);

        void AddPoints(string points);

        event PointAddedDelegate PointAdded;

        Statistics GetStatistics();
    }
}

