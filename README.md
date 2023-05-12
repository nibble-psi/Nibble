![](./docs/images/StoreLogo.png)

# Nibble

## Introduction

Nibble is a simple, lightweight, and easy to use tool for developers. Application purpose is to provide a simple way to
access and use various most common tools that
assist developers in their daily tasks. Nibble is WinUI 3 application written in C# and XAML. Architecture is based on
MVVM pattern.

## Getting Started

Nibble installation wizard will install all required dependencies. Download is available on
Github [releases](https://github.com/nibble-psi/Nibble/releases) page.

## Support and Feedback

If you have any questions, suggestions, or issues, provide feedback
on [Github issues](https://github.com/nibble-psi/Nibble/issues) page.

## Settings

### Localisation

Nibble is available in English and Lithuanian. To change language go to `Settings` page and select desired language.
Application will automatically restart and changes will take effect.

### Theme

Nibble is available in light and dark theme. To change theme go to `Settings` page and select desired theme. Theme
change will take effect immediately.

<img src="./docs/images/NibbleTools_SettingsLigth.png"  alt="" width="50%" height="50%">

<img src="./docs/images/NibbleTools_SettingsDark.png"  alt="" width="50%" height="50%">

## Available Tools and Features

### Bits Manipulation

#### Bitwise Operations

Nibble provides bitwise operations for 32 bit integers. Operations include:

- AND
- NAND
- OR
- NOR
- XOR
- NOT

Accepted input is decimal number. Result is displayed in binary format.

<img src="./docs/images/NibbleTools_Bitwise.png"  alt="" width="50%" height="50%">

#### Bit Shift Operations

Nibble provides bit shift operations for 32 bit integers. Operations include:

- Logical Left Shift
- Logical Right Shift
- Arithmetic Right Shift
- Arithmetic Right Shift
- Circular Left
- Circular Right

Accepted input is decimal number. Result is displayed in binary format.

<img src="./docs/images/NibbleTools_Bitshift.png"  alt="" width="50%" height="50%">

### Generators

Nibble provides various generators. Generators include:

#### Number Generator

Number generator generates random numbers in specified range. Generator accepts range from 0 to 2^32-1. Generator can be
used to generate random numbers for various purposes. For example, to generate random numbers for unit tests.

<img src="./docs/images/NibbleTools_NumberGen.png"  alt="" width="50%" height="50%">

#### Prime Number Generator

Prime number generator generates prime numbers in specified range. Generator accepts range from 0 to 2^32-1. Also, you
can select how many prime numbers you want to generate and digits count.

<img src="./docs/images/NibbleTools_PrimeNumber.png"  alt="" width="50%" height="50%">

#### String Generator

String generator generates random strings. Generator has provided tree modes:

- Words
- Sentences
- Paragraphs

<img src="./docs/images/NibbleTools_StringGen.png"  alt="" width="50%" height="50%">

### Regular Expressions

#### Regex Tester

Nibble provides regex tester. Regex tester can be used to test regular expressions. Regex tester accepts input string
and regular expression. Regex tester will show if input string matches regular expression.

<img src="./docs/images/NibbleTools_RegexTester.png"  alt="" width="50%" height="50%">

### Text Manipulation

#### Text Counter

Nibble provides text counter. Text counter can be used to count words, characters, and lines in text. Text counter
accepts input string and will show how many words, characters, and lines are in input string.

<img src="./docs/images/NibbleTools_TextCounter.png"  alt="" width="50%" height="50%">

#### Text Splitter

Nibble provides text splitter. Text splitter can be used to split text by specified delimiter. Text splitter accepts
input string and delimiter. Text splitter will split input string by specified delimiter or specified symbols count and
will show result.

<img src="./docs/images/NibbleTools_TextSplit.png"  alt="" width="50%" height="50%">

#### Lines Sorter

Nibble provides lines sorter. Lines sorter can be used to sort lines in text. Lines sorter accepts input string and will
sort lines in text. Provided sorting options:

- Alphabetically
- Alphabetically (Reverse)
- Randomly

<img src="./docs/images/NibbleTools_LinesSorter.png"  alt="" width="50%" height="50%">

#### Text Letter Case Converter

Nibble provides text letter case converter. Text letter case converter can be used to convert text letter case. Text
letter case converter accepts input string and will convert text letter case. Provided conversion options:

- Lowercase
- Uppercase
- Capitalize

<img src="./docs/images/NibbleTools_TextCase.png"  alt="" width="50%" height="50%">

#### Symbols Replacer

Nibble provides symbols replacer. Symbols replacer can be used to replace symbols in text. Symbols replacer accepts
input string, symbol to replace, and symbol to replace with. Symbols replacer will replace all specified symbols in
text.

<img src="./docs/images/NibbleTools_SymbolsReplace.png"  alt="" width="50%" height="50%">

### Base Number Converter

Nibble provides base number converter. Base number converter can be used to convert numbers from one base to another.
Base number converter accepts input number and base. Base number converter will convert input number to specified base.
Provided bases:

- Binary (BIN)
- Octal (OCT)
- Decimal (DEC)
- Hexadecimal (HEX)

<img src="./docs/images/NibbleTools_BaseNumber.png"  alt="" width="50%" height="50%">

### Unit Converter

Nibble provides unit converter. Unit converter can be used to convert units from one unit to another. Unit converter
accepts input number and unit. Unit converter will convert input number to specified unit. There is provided metric
units.

<img src="./docs/images/NibbleTools_Unit.png"  alt="" width="50%" height="50%">

### Unix Timestamp Converter

Nibble provides unix timestamp converter. Unix timestamp converter can be used to convert unix timestamp to date and
time. Unix timestamp converter accepts unix timestamp and will convert it to date and time.

<img src="./docs/images/NibbleTools_Unix.png"  alt="" width="50%" height="50%">

### UUID Generator

Nibble provides UUID generator. UUID generator can be used to generate UUID. UUID generator will generate UUID and will
show it. User can select count of UUIDs to generate, uppercase or lowercase, and delimiter for multiple UUIDs.

<img src="./docs/images/NibbleTools_UUID.png"  alt="" width="50%" height="50%">

### Hash Generator

Nibble provides hash generator. Hash generator can be used to generate hash from input string. Hash generator accepts
input string and will generate hash from it. Provided hash algorithms:

- MD5
- SHA1
- SHA256

<img src="./docs/images/NibbleTools_HashCode.png"  alt="" width="50%" height="50%">

### Password Generator

Nibble provides password generator. Password generator can be used to generate password. Password generator accepts
password length and will generate password with specified length. User can select if password should contain uppercase
letters, lowercase letters, digits.

<img src="./docs/images/NibbleTools_Password.png"  alt="" width="50%" height="50%">

### Markdown Preview

Nibble provides markdown preview. Markdown preview can be used to preview markdown. Markdown preview accepts markdown
and will show preview. Markdown preview supports markdown syntax highlighting.

<img src="./docs/images/NibbleTools_Markdown.png"  alt="" width="50%" height="50%">

### Color Picker

Nibble provides color picker. Color picker can be used to pick color. Color picker accepts color and will show color.
Color picker supports HEX, RGB, and HSL color formats. Color wheel can be used to pick color. Brightness slider can be
used to adjust color brightness. Transparency slider can be used to adjust color transparency.

<img src="./docs/images/NibbleTools_Color.png"  alt="" width="50%" height="50%">

### Rich Text Editor

Nibble provides rich text editor. Rich text editor can be used to edit rich text. Rich text editor supports text styling
and formatting. Rich text editor supports text styling and formatting. Rich text editor supports:

- Bold
- Italic
- Underline
- Strikethrough
- Subscript
- Superscript
- Font Family
- Font Size
- Text Alignment
- Text Color
- Background Color
- Bulleted List
- Numbered List




