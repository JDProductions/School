/**
 * Created by James on 9/16/2016.
 */
public class CourseGrades {
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
        Essay essay = new Essay(10,20,30,500);
        CourseGrades grades = new CourseGrades();
        GradedActivity activity = new GradedActivity(10);
        setLab(activity);
        return "essay score is" + essay.getScore() + " lab:" + activity;

    }


    public static void main(String[] args) {
        Essay essay = new Essay(10,20,30,500);
        CourseGrades grades = new CourseGrades();
        PassFailExam pass = new PassFailExam();
        FinalExam finalExam = new FinalExam();

        GradedActivity activity = new GradedActivity(10);
        grades.setLab(activity);

        grades.setPassFailExam(pass);
        pass.setScore(50);

        finalExam.setScore(70);


        System.out.println("Essay Score: "+ essay.getScore());
        System.out.println("Lab Score: " + activity.getScore());
        System.out.println("PassFail: " + pass.getScore());
        System.out.println("Final Exam Score: " + finalExam.getScore());

    }

}