using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDH.Strings.Translation
{
    /// <summary>
    /// In traditional grammar, a part of speech (abbreviated form: PoS or POS) is a category of words (or, more generally, of lexical items) that have similar grammatical properties.
    /// Words that are assigned to the same part of speech generally display similar synactic behavior—they play similar roles within the grammatical structure of sentences—and sometimes similar morphology in that they undergo inflection for similar properties.
    /// </summary>
    public enum PartOfSpeech
    {
        /// <summary>
        /// 
        /// </summary>
        Not_Specified,
        /// <summary>
        /// Noun (ónoma): a part of speech inflected for case, signifying a concrete or abstract entity
        /// </summary>
        noun,
        /// <summary>
        /// 
        /// </summary>
        Adjective,
        /// <summary>
        /// 
        /// </summary>
        Numeral,
        /// <summary>
        /// 
        /// </summary>
        verb,
        /// <summary>
        /// Verb (rhêma): a part of speech without case inflection, but inflected for tense, person and number, signifying an activity or process performed or undergone
        /// </summary>
        Pretext,
        /// <summary>
        /// 
        /// </summary>
        Union,
        /// <summary>
        /// 
        /// </summary>
        Particle,
        /// <summary>
        /// 
        /// </summary>
        Interjection,
        /// <summary>
        /// Participle (metokhḗ): a part of speech sharing features of the verb and the noun
        /// </summary>
        Participle,
        /// <summary>
        /// Article (árthron): a declinable part of speech, taken to include the definite article, but also the basic relative pronoun
        /// </summary>
        Article,
        /// <summary>
        /// Pronoun (antōnymíā): a part of speech substitutable for a noun and marked for a person
        /// </summary>
        Pronoun,
        /// <summary>
        /// Preposition (próthesis): a part of speech placed before other words in composition and in syntax
        /// </summary>
        Preposition,
        /// <summary>
        /// Adverb (epírrhēma): a part of speech without inflection, in modification of or in addition to a verb, adjective, clause, sentence, or other adverb
        /// </summary>
        Adverb,
        /// <summary>
        /// Conjunction (sýndesmos): a part of speech binding together the discourse and filling gaps in its interpretation
        /// </summary>
        Conjunction,
        /// <summary>
        /// 
        /// </summary>
        Transgressive,
        /// <summary>
        /// 
        /// </summary>
        Communion,
        /// <summary>
        /// 
        /// </summary>
        Determiner
    }

}
