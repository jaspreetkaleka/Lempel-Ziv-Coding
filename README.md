# Lempel-Ziv Coding
LZ78 is a lossless data-compression algorithm created by Abraham Lempel and Jacob Ziv in 1978. It works by reading a sequence of symbols, grouping the symbols into phrases, and converting the phrases into codes. 

## Example
Consider an example string.

```
A A B A B B B A B A A B A B B B A B B A B B
```
#### Codebook 

|      Index    |     0    |      1    |      2    |      3     |      4    |      5     |       6     |      7    |       8     |
|:-------------:|:--------:|:---------:|:---------:|:----------:|:---------:|:----------:|:-----------:|:---------:|:-----------:|
|     Phrase    |     Φ    |      A    |     AB    |     ABB    |      B    |     ABA    |     ABAB    |     BB    |     ABBA    |
|      Code     |          |     ΦA    |     1B    |      2B    |     ΦB    |      2A    |      5B     |     4B    |      3A     |

