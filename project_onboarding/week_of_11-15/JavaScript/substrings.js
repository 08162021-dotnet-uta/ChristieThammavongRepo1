function getVowelSubstrings(word) {
  let vowelSubstrings = [];
  for (let i = 0; i < word.length; i++) {
    if (vowels.includes(word[i]) && !vowelSubstrings.includes(word[i])) {
      vowelSubstrings.push(word[i]);
    }
    for (let j = i+1; j < word.length; j++) {
      if (
        vowels.includes(word[i]) &&
        vowels.includes(word[j]) &&
        !vowelSubstrings.includes(word.substring(i, j + 1))
      ) {
        vowelSubstrings.push(word.substring(i, j + 1));
      }
    }
  }
  console.log(vowelSubstrings.sort());
}

function getConsonantSubstrings(word) {
  let consonantSubstrings = [];
  for (let k = 0; k < word.length; k++) {
    if (!vowels.includes(word[k]) && !consonantSubstrings.includes(word[k])) {
      consonantSubstrings.push(word[k]);
    }
    for (let l = k+1; l < word.length; l++) {
      if (
        !vowels.includes(word[k]) &&
        !vowels.includes(word[l]) &&
        !consonantSubstrings.includes(word.substring(k, l + 1))
      ) {
        consonantSubstrings.push(word.substring(k, l + 1));
      }
    }
  }
  console.log(consonantSubstrings.sort());
}

let vowels = ["a", "e", "i", "o", "u"];

getVowelSubstrings("apple"); // ["a", "apple", "e"]
getVowelSubstrings("hmm"); // []
getConsonantSubstrings("aviation"); // ["n", "t", "tion", "v", "viat", "viation"]
getConsonantSubstrings("motor"); // ["m", "mot", "motor", "r", "t", "tor"]
getVowelSubstrings("oops"); // check for unique vowel values
getConsonantSubstrings("mass"); // check for unique consonant values
