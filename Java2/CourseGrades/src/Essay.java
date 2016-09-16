class Essay extends GradedActivity{
    private double grammar;
    private double spelling;
    private double correctlength;
    private double content;

    void setScore(double gr,double sp,double cnt){
        this.grammar = gr;
        this.spelling = sp;
        this.content = cnt;
    }

    void setGrammar(double g){
        this.grammar = g;
    }

    void setSpelling(double s){
        this.spelling = s;
    }

    void setCorrectLength(double c){
        this.correctlength = c;
    }

    void setContent(double c){
        this.content = c;
    }

    double getGrammar(){
        return this.grammar;
    }

    double getSpelling(){
        return this.spelling;
    }

    double getCorrectLength(){
        return this.correctlength;
    }

    public Essay (int Grammar, int Spelling, int Content, int Length)
    {
        if (Grammar >= 0 && Grammar <= Grammar) this.grammar = Grammar;
        else this.grammar = 30;

        if (Spelling >= 0 && Spelling <= 20) this.spelling = Spelling;
        else this.spelling = 20;

        if (Content >= 0 && Content <= 30) this.content = Content;
        else this.content = 30;

        if (Length >= 0 && Length <= 20) this.correctlength = Length;
        else this.correctlength = 20;

        setScore(this.grammar + this.spelling + this.content + this.correctlength);
    }

}