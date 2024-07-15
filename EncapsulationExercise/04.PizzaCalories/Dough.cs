using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories;

public class Dough
{
    private string flourType;
    private string bakeTechnique;
    private double grams;
    private const double caloriesPerGram = 2;
    public Dough(string flourType, string bakeTechnique, double grams)
    {
        FlourType = flourType;
        BakeTechnique = bakeTechnique;
        Grams = grams;
    }
    public double Calories => CaloriesPerGram * Grams;
    private double Grams
    {
        get => grams;
        set
        {
            if (value < 1 || value > 200) throw new ArgumentException("Dough weight should be in the range [1..200].");
            grams = value;
        }
    }
    private double Modifier()
    {
        double m = 1;
        if(flourType == "White") m *= 1.5;
        switch (bakeTechnique)
        {
            case "Crispy":
                m *= 0.9;
                break;
            case "Chewy":
                m *= 1.1;
                break;
        }
        return m;
    }
    public double CaloriesPerGram => caloriesPerGram * Modifier();
    private string BakeTechnique
    {
        get => bakeTechnique;
        set
        {
            if (value != "Crispy" && value != "Chewy" && value != "Homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakeTechnique = value;
        }
    }
    private string FlourType
    {
        get => flourType;
        set
        {
            if (value != "White" && value != "Wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }
}
