using System.Reflection.PortableExecutable;

namespace JeuxPendule;

public class Pendu
{

    string[] listMots = new[] { "Bonjour", "Bonsoir" }; // Liste des caractères des mots a cherchers
    public char[] listCaracterEssayes; // liste des caractères essayer par l'utilisateur
    private char[] tabMotrouve; //tableau
    private char[] tabMotAchercher;
    private Random random;

    public Pendu()
    {
        random = new Random();
        int idMot = random.Next(2); ;
        tabMotAchercher = listMots[idMot].ToCharArray(); // string
        listCaracterEssayes = new char[tabMotAchercher.Length];
    }

    public void InitPendu()
    {
        for (int i = 0; i < tabMotAchercher.Length; i++)
        {
            listCaracterEssayes[i] = '.';
        }

    }
    /// <summary>
    /// Initialisation le mot a trouver
    /// par des pointiers
    /// </summary>
    public void LoadPendule()
    {



    }

    /// <summary>
    ///  cette fonction renvoie la 
    ///  position du mot
    /// </summary>
    /// <param name="car"></param>
    /// <returns></returns>
    public int getPosition(char car)
    {

        int i = 0;
        while (i < tabMotAchercher.Length - 1 && tabMotAchercher[i] != car)
        {
            i++;

        }
        if (tabMotAchercher[i] == car)
        {
            return i;
        }
        else
        {
            return -1;
        }


    }

    /// <summary>
    /// elle remet le caracteres
    /// a la bonne position
    /// </summary>
    /// <param name="car"></param>
    /// <returns></returns>
    public char[] putCarPosition(char car)
    {
        // verifion si le caractere existe
        if (isCharExiste(car))
        {
            // trouvons la position du caractere
            //var position = getPosition(car);
            //tabMotrouve[position] = car;
        }
        return tabMotrouve;
    }

    public void afficherListeTrouver(char[] listChar)
    {
        foreach (var car in listChar)
        {
            Console.Write($"{car}");
        }
    }
    /// <summary>
    ///  elle renvoie verifie
    ///  si le caractere se trouve 
    ///  dans la chaine a trouve
    /// </summary>
    /// <param name="car"></param>
    /// <returns></returns>
    public bool isCharExiste(char car)
    {

        var motTabs = tabMotAchercher.ToArray();
        int i = 0;
        while (i < motTabs.Length - 1 && motTabs[i] != car)
        {
            i++;
        }
        if (motTabs[i] == car)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void UpdatePendu(int position, char car)
    {
        listCaracterEssayes[position] = car;
        tabMotAchercher[position] = '.';
    }

    /// <summary>
    /// cette fonction verifie 
    ///si on est arrivé a la fin 
    ///du tableau
    /// </summary>
    /// <param name="tabAtrouve"></param>
    /// <param name="car"></param>
    /// <returns></returns>
    public bool isTerminee(int position)
    {

        if (position > tabMotAchercher.Length)
        {
            return true;
        }
        else
        {
            return false;
        }

    }





}
