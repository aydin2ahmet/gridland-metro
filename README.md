# Gridland Metro

The city of Gridland is represented as an n x in matrix where the rows are numbered from 1 to n and the columns are numbered from 1 to m.Gridland has a network of train tracks that always run in straight horizontal lines along a row. In other words, the start and end points of a train track are (r, cl) and (r, c2), where r represents the row number, cl represents the starting column, and c2 represents the ending column of the train track.The mayor of Gridland is surveying the city to determine the number of locations where lampposts can be placed. A lamppost can be placed in any cell that is not occupied by a train track.Given a map of Gridland and its k train tracks, find and print the number of cells where the mayor can place lampposts.Note: A train track may overlap other train tracks within the same row.


Function Description
Complete the gridlandMetro function in the editor below.
gridlandMetro has the following parameter(s):
• int n:: the number of rows in Gridland
• int m:: the number of columns in Gridland
• int k:: the number of tracks
• track[k][3]: each element contains 3 integers that represent row, column start, column end, all 1-indexed


Returns
• int: the number of cells where lampposts can be installed
