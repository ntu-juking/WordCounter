# WordCounter
Count the words

http://www.cnblogs.com/xinz/archive/2010/11/28/1890291.html
MSRA Advanced Software Engineering

Project:  Individual Project - Word frequency program

2010/11/1
2016-9-22
考察重点:

    基本算法的实现; 基本I/O;  字处理; 程序效能分析; 简单测试用例

 

Implement a console application to tally the frequency of words under a directory (based on 2 modes).

 

For all text files under a directory (recursively) (file extensions: "txt", "cpp", "h", “cs”),   calculate the frequency of each word, and output the result into a text file.  Write the code in C#, using .Net Framework,  the running environment is 32-bit Win7.

 

Run performance analysis tool on your code, find bottlenecks and improve.

 

Enable Code Quality Analysis for your code and get rid of all warnings.

 

Write  10 simple test cases to make sure your program can handle these cases correctly (e.g.  a good test case could be: one of the sub-directories is empty).

 

Submission:

·         Submit your source code and exe to TA, TA will run it on his testing environment and check for a) correctness and b) performance

·         Submit your test cases to TA.

 

Definition:

·         A word: a string with at least 3 letters, separated by delimiters. If a string contains non-alphanumerical letters, it’s not a word.  The word is case insensitive,  i.e. “file”, “FILE” and “File” are considered the same word.

·         Delimiter: space, non-alphanumerical letters (,.<>|\)[]{!@#$%^&*()_+=-}”).

·         Output text file: filename is <your email alias>.txt

o   Each line has this format

<word>: number

                Where “number” is the number of times this word appears in the scan.  The output should be sorted with most frequently word first.  If 2 words have the same frequency, list the words by alphabetical order.

 

Requirements:

1)     Simple mode.   Simple word frequency.

Myapp.exe <directory-name>

Will output <your-alias>.txt file in current directory,  the text file contains word ranking list.

2)     Extended mode.  If 2 words are different only on the ending numbers.  For example, we consider “win”, “win95” and “win7” are ONE WORD;  “Office” and “Office15” are the same.   “win”  and “win32a” are DIFFERENT words, as the difference are more than just ending numbers. “21century” and “century” are DIFFERENT words too.

 

When running with “-e” command line parameter,

Myapp.exe –e <directory-name>

 

Will output <your-alias>.txt file  in current directory,  the text file contains word ranking list, but the frequency is calculated based on the extended mode definition. 
