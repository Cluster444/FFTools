# FFData

This project contains all the game data and available interfaces for handling data objects.

It is broken up into the following sections.

## FFTools/Data

This namespace is a combination of generated files from flatbuffers and additional interfaces/utilities.

## schemas

The FlatBuffer schema files. Each table/struct has their own file and are included where necessary.

## data

Holds CSV and JSON data that will be combined into a large JSON per root type and finally serialized into
FB binary format. The binary data is not commited but instead will be built as part of the release.
