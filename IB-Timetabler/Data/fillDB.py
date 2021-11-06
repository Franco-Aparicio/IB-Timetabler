import sqlite3

connection = sqlite3.connect("IB-Timetabler.db")
cursor = connection.cursor()


def insertRecord(table, values):
    # print(f"INSERT INTO {table} ({', '.join(values.keys())}) VALUES (:{', :'.join(values.keys())})", values)
    cursor.execute(f"INSERT INTO {table} ({', '.join(values.keys())}) VALUES (:{', :'.join(values.keys())})", values)
    connection.commit()


def selectTable(table):
    return cursor.execute(f"SELECT * FROM {table}").fetchall()


def selectAllWhere(table, field, value):
    return cursor.execute(f"SELECT * FROM {table} Where {field} = ?", (value,)).fetchall()


def deleteRecord(table, field, value):
    cursor.execute(f"DELETE FROM {table} WHERE {field} = ?", (value,))
    connection.commit()


print(selectTable("Rooms"))
# insertRecord("Rooms", {"Number": "N2.21", "Floor": 2})
# deleteRecord("Rooms", "Number", "N2.21")
print(selectTable("Rooms"))
connection.close()

classes = """12 SL Bio
12 HL Bio Z1
12 HL Bio Z2
12 SL Che
12 HL Che
12 SL Phy
12 HL Phy
13 SL Bio
13 HL Bio Z1
13 HL Bio Z2
13 SL Che
13 HL Che
13 SL Phy
13 HL Phy
12 SL Comp
12 HL Comp
13 SL Comp
13 HL Comp
12 AI SL Mat
12 AI SL/HL Mat
12 AI HL Mat
12 AA SL Mat
12 AA SL/HL Mat
12 AA HL Mat
13 AI SL Mat
13 AI SL/HL Mat
13 AI HL Mat
13 AA SL Mat 1
13 AA SL Mat 2
13 AA SL/HL Mat
13 AA HL Mat
12 SL Eng Lang & Lit 1
12 SL Eng Lang & Lit 2
12 HL Eng Lang & Lit 3
12 HL Eng B 1
12 HL Eng B 2
12 HL Eng B 3
13 SL Eng Lit 1
13 HL Eng Lit 1
13 HL Eng B 1
13 HL Eng B 2
23 SL Geog
23 HL Geog
22 SL Geog
22 HL Geog
"""

numLessons = """6
10
10
6
4
6
4
6
10
10
6
4
6
4
6
4
6
4
6
6
4
6
6
4
6
6
4
6
6
6
4
6
6
10
10
10
10
6
10
10
10
6
4
6
4
"""
years = """12
12
12
12
12
12
12
13
13
13
13
13
13
13
12
12
13
13
12
12
12
12
12
12
13
13
13
13
13
13
13
12
12
12
12
12
12
13
13
13
13
12
12
13
13
"""

teachers = """S8
S1
S3
S2
S2
S4
S4
S5
S6
S8
S7
S7
S4
S4
C1
C1
C1
C1
M6
M4
M4
M1
M2
M2
M5
M4
M4
M2
M3
M1
M1
E3
E5
E1
E7
E2
E4
E1
E6
E4
E5
H2
H2
H4
H1
"""
