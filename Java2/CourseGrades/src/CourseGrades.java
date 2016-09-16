/**
 * Created by James on 9/16/2016.
 */
public class CourseGrades implements Analyzable {
    GradedActivity[] grades = new GradedActivity[4];


    public void setLab(GradedActivity lab) {
        this.grades[0] = lab;
    }

    public void setPassFailExam(PassFailExam passFailExam) {
        this.grades[1] = passFailExam;
    }

    public void setEssay(Essay essay) {
        this.grades[2] = essay;
    }

    public void setFinalExam(FinalExam finalExam) {
        this.grades[3] = finalExam;
    }

    public String toString() {
        Essay essay = new Essay(10, 20, 30, 500);
        CourseGrades grades = new CourseGrades();
        PassFailExam pass = new PassFailExam();
        FinalExam finalExam = new FinalExam();

        GradedActivity activity = new GradedActivity(10);
        grades.setLab(activity);

        grades.setPassFailExam(pass);
        pass.setScore(50);

        finalExam.setScore(70);
        return "essay" + essay.getScore() + "lab" + activity.getScore() + "PassFail" + pass.getScore() + "FinalExamScore" + finalExam.getScore();

    }

    @Override
    public double getAverage() {
        Essay essay = new Essay(10, 20, 30, 500);
        CourseGrades grades = new CourseGrades();
        PassFailExam pass = new PassFailExam();
        FinalExam finalExam = new FinalExam();

        GradedActivity activity = new GradedActivity(10);
        grades.setLab(activity);

        grades.setPassFailExam(pass);
        pass.setScore(50);

        finalExam.setScore(70);
        return essay.getScore() + activity.getScore() + pass.getScore() + finalExam.getScore() / 4;
    }

    @Override
    public GradedActivity getHighest() {
        Essay essay = new Essay(10, 20, 30, 500);
        CourseGrades grades = new CourseGrades();
        PassFailExam pass = new PassFailExam();
        FinalExam finalExam = new FinalExam();

        GradedActivity activity = new GradedActivity(10);


        double max = essay.getScore();
        if (activity.getScore() > max) {
            max = activity.getScore();
        }
        if (pass.getScore() > max) {
            max = pass.getScore();
        }
        if (finalExam.getScore() > max) {
            max = finalExam.getScore();
        }

        System.out.println("The Highest Score is " + max);

        return null;
    }

    @Override
    public GradedActivity getLowest() {
        Essay essay = new Essay(10, 20, 30, 500);
        CourseGrades grades = new CourseGrades();
        PassFailExam pass = new PassFailExam();
        FinalExam finalExam = new FinalExam();
        GradedActivity activity = new GradedActivity(10);


        grades.setLab(activity);

        grades.setPassFailExam(pass);
        pass.setScore(50);

        finalExam.setScore(70);

        double min = essay.getScore();
        if (activity.getScore() < min) {
            min = activity.getScore();
        }
        if ( pass.getScore() < min) {
            min = pass.getScore();
        }
        if (finalExam.getScore() < min) {
            min = finalExam.getScore();
        }

        System.out.println("The lowest score is " + min);

        return null;
    }


    public static void main(String[] args) {

        Essay essay = new Essay(10, 20, 30, 500);
        CourseGrades grades = new CourseGrades();
        PassFailExam pass = new PassFailExam();
        FinalExam finalExam = new FinalExam();
        //grades.toString();

        GradedActivity activity = new GradedActivity(10);
        grades.setLab(activity);

        grades.setPassFailExam(pass);
        pass.setScore(50);

        finalExam.setScore(70);


        System.out.println("Essay Score: " + essay.getScore());
        System.out.println("Lab Score: " + activity.getScore());
        System.out.println("PassFail: " + pass.getScore());
        System.out.println("Final Exam Score: " + finalExam.getScore());
        System.out.println("The average: " + grades.getAverage());
        grades.getHighest();
        grades.getLowest();

    }
}

