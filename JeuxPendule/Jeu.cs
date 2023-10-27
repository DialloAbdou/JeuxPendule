namespace JeuxPendule;

public class Jeu
{

    private Pendu pendu = new Pendu();
    private char[]? tabMotTrouve = null;
    bool gagne = false;

    public Jeu()
    {
        initJeu();
    }
    /// <summary>
    /// / Initialisation
    /// </summary>
    public void initJeu()
    {
        pendu.InitPendu();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="chaine"></param>
    /// <returns></returns>
    private char getChar(string chaine)
    {
        return char.Parse(chaine);
    }

    /// <summary>
    ///  cette fonction indique si
    ///  le jeu es terminée !
    /// </summary>
    /// <param name="car"></param>
    /// <returns></returns>
    public bool IsJeuTermine(char car)
    {
        return pendu.isTerminee(car);
    }

    /// <summary>
    ///  la fonction principale 
    ///  qui prend en parametre 
    ///  le caractere saisie par l'utilisateur
    /// </summary>
    /// <param name="chaine"></param>
    public void goJeu()
    {
        while (!gagne)
        {
            Console.Clear();
            Console.WriteLine("les caracteres saisie!");
          
            for (int i = 0; i < pendu.listCaracterEssayes.Length; i++)
            {
                Console.Write(pendu.listCaracterEssayes[i]);
            }
              
            
            Console.WriteLine("");
            Console.WriteLine("Veuillez saisir un caractere !");
            // siaisir le caractère
            string chaine = Console.ReadLine();
            char car = this.getChar(chaine); 
            if (pendu.isCharExiste(car))
            {
                int position = pendu.getPosition(car);
                pendu.UpdatePendu(position, car);
                gagne = pendu.isTerminee(position);

            }
        }

    }




}
