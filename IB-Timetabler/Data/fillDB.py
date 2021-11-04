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

classes = """12 IB SL Bio
12 IB HL Bio Z1
12 IB HL Bio Z2
12 IB SL Che
12 IB HL Che
12 IB SL Phy
12 IB HL Phy
13 IB SL Bio
13 IB HL Bio Z1
13 IB HL Bio Z2
13 IB SL Che
13 IB HL Che
13 IB SL Phy
13 IB HL Phy
12 IB SL Comp
12 IB HL Comp
13 IB SL Comp
13 IB HL Comp
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
"""
