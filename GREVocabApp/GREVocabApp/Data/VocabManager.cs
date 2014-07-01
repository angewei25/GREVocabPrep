using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GREVocabApp.Data
{
    public class VocabManager
    {
        private static VocabManager instance;
        private Dictionary<Vocab, int> vocabulary;
        private Dictionary<String, Vocab> wordList;

        private VocabManager() 
        {
            vocabulary = new Dictionary<Vocab, int>();
            wordList = new Dictionary<string, Vocab>();
        }

        public static VocabManager GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VocabManager();
                }
                return instance;
            }
        }

        public void Load()
        {
            foreach (var t in highFreqVocab)
            {
                var word = new Vocab(t.Item1, t.Item2, t.Item3);
                vocabulary.Add(word, 1);
                wordList.Add(t.Item1, word);
            }

            foreach (var t in Vocab)
            {
                var word = new Vocab(t.Item1, t.Item2, t.Item3);
                vocabulary.Add(word, 1);
                wordList.Add(t.Item1, word);
            }

        }

        public IEnumerable<String> Words
        {
            get { return wordList.Keys; }
        }

        public Vocab FindVocab(String word)
        {
            if (wordList.Keys.Contains(word))
            {
                return wordList[word];
            }
            return null;
        }

        private static List<Tuple<String, String, String>> highFreqVocab = new List<Tuple<String, String, String>>
        {
            //TODO: insert all the high freq vocab to be studied here
            new Tuple<String, String, String>("A", "", ""),
            new Tuple<String, String, String>("abate", "subside or moderate", "Rather than leaving immediately, they waited for the storm to abate."),
            new Tuple<String, String, String>("aberrant", "abnormal or deviant", "Given the aberrant nature of the data, we came to doubt the validity of the entire experiment."),
            new Tuple<String, String, String>("abeyance", "suspended action", "The deal was held in abeyance until her arrival."),
            new Tuple<String, String, String>("absond", "depart secretly and hide", "The teller who absconded with the bonds went uncaptured until soemone recognized him from his photograph on America's Most Wanted."),
            new Tuple<String, String, String>("abstemious", "sparing in eating and drinking; temperate", "Concerned whether her vegetarian son's abstemious diet provided him with sufficient protein, the worried mother pressed food on him."),
            new Tuple<String, String, String>("admonish", "warn; reprove", "when her courtiers questioned her religious beliefs, Mary Stuart admonished them, declaring that she would worship as she pleased."),
            new Tuple<String, String, String>("adulterate", "make impure by adding inferior or tainted substances", "It is a crime to adulterate foods without informing the buyer; when consumers learned that Beechnut had adulterated its apple juice by mixing the juice with water, they protested vigorously."),
            new Tuple<String, String, String>("aesthetic", "artistic; dealing with or capable of appreciating the beautiful", "The beauty of Tiffany's stained glass appealed to Alice's aesthetic sense"),
            new Tuple<String, String, String>("aggregate", "gather; accumulate", "Before the Wall Street scandals, dealers in so-called junk bonds managed to aggregate great wealth in short periods of time."),
            new Tuple<String, String, String>("alacrity", "cheeful promptness; eagerness", "Phil and Dave were raring to get off the mountains; they packed up their ski gear and climbed into the van with alacrity."),
            new Tuple<String, String, String>("alleviate", "relieve", "This should alleviate the pain; if it does not, we shall have to use stronger drugs."),
            new Tuple<String, String, String>("amalgamate", "combine; unite in one body", "The unions will attempt to amalgamate their groups into one national body."),
            new Tuple<String, String, String>("ambiguous", "unclear or doubtful in meaning", "His ambiguous instructions misled us; we did not know which road to take."),
            new Tuple<String, String, String>("ambivalence", "the state of having contradictory or conflicting emotional attitudes", "Torn between loving her parents one minute and hating them the next, she was confused by the ambivalence of her feelings."),
            new Tuple<String, String, String>("ameliorate", "improve", "Many social workers have attempted to ameliorate the conditions of people living in the slums"),
            new Tuple<String, String, String>("anachronism", "something or someone misplaced in time", "Shakespeare's reference to clocks in Julius Caesar is an anachronism; no clocks existed in Caesar's time."),
            new Tuple<String, String, String>("analogous", "comparable", "She called our attention to the things that we had been done in an analogous situation and recommended that we do the same."),
            new Tuple<String, String, String>("anarchy", "absence of governing body; state of disorder", "The assassination of the leaders led to a period of anarchy."),
            new Tuple<String, String, String>("anomalous", "abnomal; irregular", "She was placed in the anomalous position of seeing to approve procedures that she despised."),
            new Tuple<String, String, String>("antipathy", "aversion; dislike", "Tom's extreme antipathy for disputes keeps him from getting into argumens with his temperamental wife. Noise in any form is antipathetic to him. Among his other antipathies are hoboom boxes, and heavy metal rock."),
            new Tuple<String, String, String>("apathy", "lack of caring; indifference", "A firm believer in democratic government, she could not understand the apathy of people who never bothered to vote."),
            new Tuple<String, String, String>("appease", "pacify or soothe; relieve", "Tom and Jody tried to appease the crying baby by offering him one toy after another. However, he would not calm down until they appeased his hunger by giving him a bottle."),
            new Tuple<String, String, String>("apprise", "inform", "When NASA was apprised of the dangerous weather conditions, the head of the space agency decided to postpone the shuttle launch."),
            new Tuple<String, String, String>("approbation", "approval", "Wanting her parents' regard, she looked for some sign of their approbabtion."),
            new Tuple<String, String, String>("appropriate", "acquire; take possession of for one's own use", "The ranch owners appropriated the lands that had originally been set aside for the Indians' use."),
            new Tuple<String, String, String>("arduous", "hard; strenuous", "Her arduous efforts had sapped her energy."),
            new Tuple<String, String, String>("artless", "without guile; open and honest", "Red Riding Hood's artless comment, 'Grandma, what big eeys you have!' indicates the child's innocent surprise at her 'grandmother's' changed appearance."),
            new Tuple<String, String, String>("ascetic", "practicing self-denial; austere.", "The wealthy, self-indulgent young man felt oddly drawn to the strict, ascetic life led by members of soem monastic orders."),
            new Tuple<String, String, String>("assiduous", "diligent", "It took Rembrandt weeks of assiduous labor before he was satisfied with his portrait of his son."),
            new Tuple<String, String, String>("assuage", "ease or lessen (pain); satisfy (hunger); soothe (anger)", "Jilted by Jane, Dick tried to assuage his heartache by indulging in icecream. One gallon later, he had assuaged his appetite but not his grief."),
            new Tuple<String, String, String>("attenuate", "make thinner; weaker or lesson (in density, force, degree)", "The long, dry spell attenuated the creek to the merest trickle. When a meteor strikes the ground, the initally intense shock attenuates or lessens as it diverges otuward."),
            new Tuple<String, String, String>("audacious", "daring; bold", "Audiences cheered as Luke Skywalker and Princess Leia made their audacious, death-defying leap to freedom and escaped Darth Vader's troops."),
            new Tuple<String, String, String>("austere", "forbiddingly stern; severely simple and unornamented", "The headmaster's austere demeanor tended to scare off the more timid students, who never visted his study willingly. The room reflected the man, austere and bare, like a monk's cell, with no touches of luxury to moderate its austerity."),
            new Tuple<String, String, String>("autonomous", "self-governing", "Although the University of California at Berkeley is just one part of the state university system, in many ways Cal Berkeley is autonomous, for it runs several programs that are not subject to outside control."),
            new Tuple<String, String, String>("aver", "assert confidently or declare; as used in law, state formally as a fact", "The self-proclaimed psychic averred that, because he had extrasensory perception on which to base his predictions, he needed no seismographs or other gadgets in order to foretell earthquakes."),
            
        };

        private static List<Tuple<String, String, String>> Vocab = new List<Tuple<String, String, String>>
        {
            //TODO: insert all the vocab to be studied here
            new Tuple<String, String, String>("a", "b", "c"),
        };
    }
}
