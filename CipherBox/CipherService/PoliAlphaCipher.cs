using CipherBox.CipherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherBox.CipherService
{
    internal class PoliAlphaCipher
    {
        private int n = 0;
        private AlphabeticSubstitutionModel cipher;

        public int N
        {
            get { return n; }
            set { n = value;
                cipher = new AlphabeticSubstitutionModel(n);
            }
        }

        public string get_display_text()
        {
            return cipher.ToString();
        }

        public string Encrypt_Poli_Alpha(string plainText)
        {
            cipher.plainText = plainText;
            cipher.Encrypt();
            return cipher.encryptedText;
        }

        public string Decrypt_Poli_Alphabetic(string encryptedText)
        {
            cipher.encryptedText = encryptedText;
            cipher.Decrypt();
            return cipher.plainText;
            //*
            //looking back we met in such an odd way arigatou 
            ///p[pudding chand and I 
            ///bring me and egg with whites
            ///thank you pudding chan 
            ///let me mix it this time
            ///uk pleaase do
            /// impoirtant presentation. okay
            /// i fooled you and tried to kill you. don't thaank my sanji san
            /// i really want to apologize 
            /// thje whole thing was staged bu the big amom pirates pudding chan de oykata 
            /// just onee for the last time 
            /// they kissed 
            /// omggggggggggnuuuu de ce 
            /// ai futa rupa de ce 
            /// nu vreau i will never lose 
            /// yoy ce bine ca pica 
            /// survived intil this poinnt headline newa next scoop we swallowed our pride ewe wont let him get away good news soon 
            /// 12:43 am
            /// stopgive me the cake 
            /// Put it out now we cant go on father we re gonna die before we reach the island dont get fdfllustered now
            /// at least die together 
            /// Father!I see it
            /// Rero
            /// maniless guysstopped aattacking ambus at cacao island
            /// what should we do
            /// i have no choice we believe in you luffy 
            /// 47 am 
            /// both of them are passed out luffy woke up at 47
            /// cacao island how many aare there
            /// massive fleet sanji kul what are we gonna dfo
            /// dont get close
            /// luffy to the shiip somehow 
            /// are your weapons reagy
            /// kakaturi wants big mom defefated ill make you pay for this gaarrrr
            /// come one jhow straw hat luffy 
            /// luffy hurry up who said you can go first raock paper scisors  squish him up already hurry uds  fuggyrun wild pedro aniki full moon tongiht sacrificed himself okey thanks 
            /// do your work for us lets gothat bastard
            /// come out already dont move big brulle sbrains out dont do it pekoms 
            /// pekoms what are yyou thinking taskete minaaa doesnt matter now keep straw hat alive masaka trying to become sulong
            /// nooooo hold him down
            /// its to late prepate yourself
            /// you bastard 
            /// whats this all about 
            /// katakuri or strwahat for no reason 
            /// brig brooo
            /// heat beating ouch
            /// no 
            /// yay straw hat luffy 
            /// ppelkoms was hiding him smart to jump just surrender hhmmm sanji big gro raising did you win
            /// i knew it we can use geppo too 
            /// one tho three four five six bugi wara isnt that right big bro pedro
            /// dont let them get away kick everyone s ass is that pekoms dont get uin our way pelkoms 
            /// hows that electro 
            /// unbelievably strong and out of control   everythings gonna be alright. anikiiii. why the fuck did sanji sfall asleep take straw hat get clear away at any cost okay! 
            /// don
            /// t push your luck 
            /// make it so hell never see the full moon again 
            /// spears
            /// pekoms!
            /// everything will be alright. big bro... 
            /// aniki 
            /// not paying attention 
            /// is disrespectful 
            /// sanji meri odata futa te dumnezo germa s fleet 
            /// why are they here 
            /// iooooooooooooooi ffinally 
            /// woooho germa power 
            //
            //*// 
        }
    }
}
