using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeJeroen.Questions
{
    public class QuestionConstructor
    {
        /// <summary>
        /// A random generator to make the questions generate random
        /// </summary>
        private Random _random;

        /// <summary>
        /// Constructor of the question factory
        /// </summary>
        public QuestionConstructor()
        {
            _random = new Random();
        }

        /// <summary>
        /// The method to get 10 random questions
        /// </summary>
        /// <returns>A list of 10 questions</returns>
        public List<Question> GetQuestions(int questionAmount)
        {
            List<Question> questions = new List<Question>();
            int randomQuestionNumber;
            bool questionInList;

            for (int i = 0; i < questionAmount; i++)
            {
                questionInList = false;
                randomQuestionNumber = _random.Next(1, 44);
                
                foreach (Question questionNr in questions)
                {
                    if (questionNr.QuestionNr == randomQuestionNumber)
                    {
                        i--;
                        questionInList = true;
                        break;
                    }
                }

                if (!questionInList)
                {
                    questions.Add(GetQuestion(randomQuestionNumber));
                }
            }

            return questions;
        }

        /// <summary>
        /// This method constructs the question
        /// </summary>
        /// <param name="Nr">which question to construct</param>
        /// <returns>A complete question</returns>
        private Question GetQuestion(int Nr)
        {
            int questionNr = Nr;
            String questionText = "";
            String answer1 = "";
            String answer2 = "";
            String answer3 = "";
            String answer4 = "";
            int correctAnswer = 0;

            switch (Nr)
            {
                case 1:
                    questionText = "In welke maateenheid wordt typisch een beeldscherm aangeduid?";
                    answer1 = "Inch";
                    answer2 = "Centimeter";
                    answer3 = "Feet";
                    answer4 = "Milimeter";
                    correctAnswer = 1;
                    break;
                case 2:
                    questionText = "Welke toetsenbord indeling gebruiken we in Nederland?";
                    answer1 = "Azerty";
                    answer2 = "Dvorak";
                    answer3 = "Qwerty";
                    answer4 = "Qzerty";
                    correctAnswer = 3;
                    break;
                case 3:
                    questionText = "Hoe noemt men een kunstof colafles?";
                    answer1 = "PEfles";
                    answer2 = "Petfles";
                    answer3 = "Drogfles";
                    answer4 = "PPfles";
                    correctAnswer = 2;
                    break;
                case 4:
                    questionText = "Hoeveel potloodbatterijen maken samen 4,5 volt";
                    answer1 = "1";
                    answer2 = "3";
                    answer3 = "6";
                    answer4 = "12";
                    correctAnswer = 2;
                    break;
                case 5:
                    questionText = "Wat is een andere benaming voor een sifon?";
                    answer1 = "Rioolpijp";
                    answer2 = "De afvoer";
                    answer3 = "Zwanenhals";
                    answer4 = "Eendenkop";
                    correctAnswer = 3;
                    break;
                case 6:
                    questionText = "Wat is de tegenhanger van gelijkspanning?";
                    answer1 = "Gladspanning";
                    answer2 = "Tegenspanning";
                    answer3 = "Blauwe spanning";
                    answer4 = "Wisselspanning";
                    correctAnswer = 4;
                    break;
                case 7:
                    questionText = "Hoe noem je de soort lamp die als koplamp in de auto wordt gebruikt?";
                    answer1 = "Nacht";
                    answer2 = "Gloei";
                    answer3 = "Fel";
                    answer4 = "Hallogeen";
                    correctAnswer = 4;
                    break;
                case 8:
                    questionText = "Wat geeft een gloeilamp het meest af?";
                    answer1 = "Warmte";
                    answer2 = "Licht";
                    answer3 = "Straling";
                    answer4 = "5e Signaal";
                    correctAnswer = 1;
                    break;
                case 9:
                    questionText = "Hoe luidt de stelling van Pythagoras?";
                    answer1 = "Akwadraat + Bkwadraat = Ckwadraat";
                    answer2 = "E = M * Ckwadraat";
                    answer3 = "sin(-t) = -sin t";
                    answer4 = "A + -A = 0";
                    correctAnswer = 1;
                    break;
                case 10:
                    questionText = "Welk metaalsoort is een van de lichtste?";
                    answer1 = "Zeldzaamium";
                    answer2 = "Goud";
                    answer3 = "Aluminium";
                    answer4 = "Lithium";
                    correctAnswer = 3;
                    break;
                case 11:
                    questionText = "Welke kleur bloedlichaampjes kennen we?";
                    answer1 = "Rood en geel";
                    answer2 = "Geel en blauw";
                    answer3 = "Wit en rood";
                    answer4 = "Blauw en wit";
                    correctAnswer = 3;
                    break;
                case 12:
                    questionText = "Vergeleken met de aarde is op de maan de zwaartekracht?";
                    answer1 = "Hoger";
                    answer2 = "Even groot";
                    answer3 = "Omgekeerd";
                    answer4 = "Lager";
                    correctAnswer = 4;
                    break;
                case 13:
                    questionText = "Wat is de hardste steen op aarde?";
                    answer1 = "Unobtainium";
                    answer2 = "Diamand";
                    answer3 = "Obsidiaan";
                    answer4 = "Robijn";
                    correctAnswer = 2;
                    break;
                case 14:
                    questionText = "In welk jaar was de eerste maanlanding?";
                    answer1 = "1969";
                    answer2 = "1997";
                    answer3 = "1942";
                    answer4 = "1974";
                    correctAnswer = 1;
                    break;
                case 15:
                    questionText = "Hoe wordt een 5 puntige ster ook wel genoemd?";
                    answer1 = "Jodenster";
                    answer2 = "Een voldoende-ster";
                    answer3 = "Davidsster";
                    answer4 = "Pentagram";
                    correctAnswer = 4;
                    break;
                case 16:
                    questionText = "Waar staat het getal 3,14 voor?";
                    answer1 = "Trt";
                    answer2 = "Pi";
                    answer3 = "Het Zongetal";
                    answer4 = "Het halve wiel getal";
                    correctAnswer = 2;
                    break;
                case 17:
                    questionText = "Op welke brandstof reed de eerste trein?";
                    answer1 = "Diesel";
                    answer2 = "Kernenergie";
                    answer3 = "Stroom";
                    answer4 = "Stoom";
                    correctAnswer = 4;
                    break;
                case 18:
                    questionText = "Welke letter staat voor 1000?";
                    answer1 = "K";
                    answer2 = "C";
                    answer3 = "M";
                    answer4 = "G";
                    correctAnswer = 1;
                    break;
                case 19:
                    questionText = "Hoe heet het besturingssysteem van de Iphone?";
                    answer1 = "Android";
                    answer2 = "IoS";
                    answer3 = "Windows";
                    answer4 = "Linux";
                    correctAnswer = 2;
                    break;
                case 20:
                    questionText = "Hoe heet de camera voor de Xbox die het mogelijk maakt je lichaam als controller te gebruiken?";
                    answer1 = "De Move";
                    answer2 = "VR";
                    answer3 = "De revolution";
                    answer4 = "De kinect";
                    correctAnswer = 4;
                    break;
                case 21:
                    questionText = "Welk bedrijf ontwikkelde de Blackberry?";
                    answer1 = "Microsoft";
                    answer2 = "Paradox studio";
                    answer3 = "Research in Motion";
                    answer4 = "Orange BV";
                    correctAnswer = 3;
                    break;
                case 22:
                    questionText = "Wat is de naam van de extra grote variant van de Nintendo 3DS?";
                    answer1 = "Nintendo DSi";
                    answer2 = "Nintendo WiiU";
                    answer3 = "Nintendo 3DS XL";
                    answer4 = "Nintendo 3DS Giga";
                    correctAnswer = 3;
                    break;
                case 23:
                    questionText = "Uit welk land komt Nokia?";
                    answer1 = "Finland";
                    answer2 = "Letland";
                    answer3 = "Rusland";
                    answer4 = "Duitsland";
                    correctAnswer = 1;
                    break;
                case 24:
                    questionText = "Voor welke stof staat de afkorting H2O?";
                    answer1 = "Azijn";
                    answer2 = "Waterstof";
                    answer3 = "Plutonium";
                    answer4 = "Water";
                    correctAnswer = 4;
                    break;
                case 25:
                    questionText = "Voor welke stof staat de afkorting C6H12O6?";
                    answer1 = "Lactose";
                    answer2 = "Fructose";
                    answer3 = "Glucose";
                    answer4 = "Alchohol";
                    correctAnswer = 3;
                    break;
                case 26:
                    questionText = "Hoe noem je de printvulling van een laserprint?";
                    answer1 = "Toner";
                    answer2 = "Lazer inkt";
                    answer3 = "Ifra cassette";
                    answer4 = "Skera vulling";
                    correctAnswer = 1;
                    break;
                case 27:
                    questionText = "Wat zijn de 3 primaire kleuren van een beeldpixel?";
                    answer1 = "Geel, blauw en rood";
                    answer2 = "Rood, groen en blauw";
                    answer3 = "Wit, zwart en bruin";
                    answer4 = "Orange, paars en groen";
                    correctAnswer = 2;
                    break;
                case 28:
                    questionText = "Waarmee kun je een uitvinding beschermen?";
                    answer1 = "Een pistool";
                    answer2 = "Smeken het niet te stelen";
                    answer3 = "Kung fuu";
                    answer4 = "Octrooi";
                    correctAnswer = 4;
                    break;
                case 29:
                    questionText = "Hoe wordt een meteoor die de aarde bereikt genoemd?";
                    answer1 = "Diariet";
                    answer2 = "Pulsar";
                    answer3 = "Komeet";
                    answer4 = "Meteoriet";
                    correctAnswer = 4;
                    break;
                case 30:
                    questionText = "Aan hoeveel pixels is 1 megapixel gelijk?";
                    answer1 = "1 miljoen";
                    answer2 = "1 miljard";
                    answer3 = "100 duizend";
                    answer4 = "1 triljoen";
                    correctAnswer = 1;
                    break;
                case 31:
                    questionText = "Wat is de natuurkundige eenheid van druk?";
                    answer1 = "Atmosfeer";
                    answer2 = "Bar";
                    answer3 = "Yiem";
                    answer4 = "Aquece";
                    correctAnswer = 2;
                    break;
                case 32:
                    questionText = "Hoeveel tanden en kiezen heeft een volwassen persoon?";
                    answer1 = "29";
                    answer2 = "30";
                    answer3 = "32";
                    answer4 = "34";
                    correctAnswer = 3;
                    break;
                case 33:
                    questionText = "Welk metaal is als enige bij kamertemperatuur vloeibaar?";
                    answer1 = "Kwik";
                    answer2 = "Aluminium";
                    answer3 = "Brons";
                    answer4 = "Nikkel";
                    correctAnswer = 1;
                    break;
                case 34:
                    questionText = "Hoeveel kilobyte is 1 megabyte?";
                    answer1 = "1000";
                    answer2 = "1024";
                    answer3 = "988";
                    answer4 = "1048";
                    correctAnswer = 2;
                    break;
                case 35:
                    questionText = "Op hoeveel volt werkt een USB aansluiting?";
                    answer1 = "6 volt";
                    answer2 = "3,5 volt";
                    answer3 = "5 volt";
                    answer4 = "12 volt";
                    correctAnswer = 3;
                    break;
                case 36:
                    questionText = "Wat is de snelheid van geluid?";
                    answer1 = "340 meter per seconde";
                    answer2 = "380 meter per seconde";
                    answer3 = "300 meter per seconde";
                    answer4 = "360 meter per seconde";
                    correctAnswer = 1;
                    break;
                case 37:
                    questionText = "Met welk gas wordt een ballon opgeblazen die kan zweven?";
                    answer1 = "Helium";
                    answer2 = "Neon";
                    answer3 = "Argon";
                    answer4 = "Krypton";
                    correctAnswer = 1;
                    break;
                case 38:
                    questionText = "In welk jaar werd de allereerste sms verstuurd?";
                    answer1 = "1991";
                    answer2 = "1992";
                    answer3 = "1993";
                    answer4 = "1994";
                    correctAnswer = 2;
                    break;
                case 39:
                    questionText = "Wat is de codenaam van Android 4.1?";
                    answer1 = "Garden Table";
                    answer2 = "Choco Kiss";
                    answer3 = "Jelly Bean";
                    answer4 = "Fancy Palm";
                    correctAnswer = 3;
                    break;
                case 40:
                    questionText = "Waarvoor staat de I in de afkorting HDMI?";
                    answer1 = "Infrared";
                    answer2 = "Imagen";
                    answer3 = "Interface";
                    answer4 = "Iriken";
                    correctAnswer = 3;
                    break;
                case 41:
                    questionText = "Hoe heette vroeger de koelende vloeistof in een vriezer?";
                    answer1 = "Caesiuum";
                    answer2 = "Astaat";
                    answer3 = "Koolstof";
                    answer4 = "Freon";
                    correctAnswer = 4;
                    break;
                case 42:
                    questionText = "Wat is de gemiddelde snelheid van een groot passagiers vliegtuig?";
                    answer1 = "960 km/u";
                    answer2 = "920 km/u";
                    answer3 = "1100 km/u";
                    answer4 = "1000 km/u";
                    correctAnswer = 4;
                    break;
                case 43:
                    questionText = "Wie was de uitvinder van elektriciteit?";
                    answer1 = "Nikola Tesla";
                    answer2 = "Humphry Davy";
                    answer3 = "Heinrich Göbel";
                    answer4 = "Thomas Edison";
                    correctAnswer = 4;
                    break;
                
                    }

            Question returnQuestion 
                = new Question(questionNr, questionText, answer1, answer2, answer3, answer4, correctAnswer);
            return returnQuestion;
        }
    }
}
