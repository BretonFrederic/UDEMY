public class Voiture {
    int nbPortes = 5;
    boolean automatique;
    String couleur;
    int rapportCourant;
    int vitesse;
    Moteur moteur;

    void klaxonner(){
        System.out.println("Tutut!!!");
    }

    int accelerer(){
        System.out.println("J'accélère");
        return 100;
    }

    int accelerer(int _vitesse){
        System.out.println("j'accélère");
        this.vitesse = this.vitesse + _vitesse;
        return this.vitesse;
    }
}
