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


# print(selectTable("Rooms"))
# insertRecord("Rooms", {"Number": "N2.21", "Floor": 2})
# deleteRecord("Rooms", "Number", "N2.21")
# print(selectTable("Rooms"))


class Lesson:

    def __init__(self, name, year, numLessons, teacher, blocks, group):
        self.Name = name
        self.Year = year
        self.NumLessons = numLessons
        self.Teacher = teacher
        self.Blocks = blocks
        self.Group = group


def makeTables():
    cursor.execute('CREATE TABLE IF NOT EXISTS Blocks ( ID INTEGER NOT NULL, Block INTEGER NOT NULL, '
                   'PRIMARY KEY(ID AUTOINCREMENT) )')
    cursor.execute('CREATE TABLE IF NOT EXISTS LessonIDBlockID ( LessonID INTEGER NOT NULL, BlockID '
                   'INTEGER NOT NULL )')
    cursor.execute('CREATE TABLE IF NOT EXISTS Lessons ( ID INTEGER NOT NULL, Name TEXT NOT NULL, '
                   'Year INTEGER NOT NULL, Group TEXT NOT NULL, ClassCode TEXT NOT NULL, NumLessons '
                   'INTEGER NOT NULL, TeacherID INTEGER NOT NULL, PRIMARY KEY(ID AUTOINCREMENT) )')
    cursor.execute('CREATE TABLE IF NOT EXISTS Periods ( ID INTEGER NOT NULL, Week INTEGER NOT NULL, '
                   'Day INTEGER NOT NULL, TimePeriod INTEGER NOT NULL, PRIMARY KEY(ID AUTOINCREMENT) )')
    cursor.execute('CREATE TABLE IF NOT EXISTS RoomIDLessonID ( RoomID INTEGER NOT NULL, LessonID '
                   'INTEGER NOT NULL )')
    cursor.execute('CREATE TABLE IF NOT EXISTS Rooms ( ID INTEGER NOT NULL, Number TEXT NOT NULL, '
                   'Floor INTEGER NOT NULL, PRIMARY KEY(ID AUTOINCREMENT) )')
    cursor.execute('CREATE TABLE IF NOT EXISTS SavedLessons ( SaveID INTEGER NOT NULL, Lesson TEXT NOT NULL, '
                   'Teacher TEXT NOT NULL, Room TEXT NOT NULL )')
    cursor.execute('CREATE TABLE IF NOT EXISTS Saves ( ID INTEGER NOT NULL, Name TEXT NOT NULL, '
                   'PRIMARY KEY(ID AUTOINCREMENT) )')
    cursor.execute('CREATE TABLE IF NOT EXISTS SavedLessonIDPeriodID ( SavedLessonID INTEGER NOT NULL, '
                   'PeriodID INTEGER NOT NULL )')
    cursor.execute('CREATE TABLE IF NOT EXISTS Teachers ( ID INTEGER NOT NULL, Name TEXT NOT NULL, '
                   'PRIMARY KEY(ID AUTOINCREMENT) )')


def fillDB():
    makeTables()
    if len(selectTable("Blocks")) == 0:
        for i in range(1, 7):
            insertRecord("Blocks", {"Block": i})

    names = """12 SL Bio
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
    23 SL His
    23 HL His
    22 SL His
    22 HL His
    23 SL Econ
    23 HL Econ
    22 SL Econ
    22 HL Econ
    23 SL A BUSMAN
    23 HL A BUSMAN
    23 SL B BUSMAN
    23 HL B BUSMAN
    22 SL S3B BUSMAN
    22 SL S3C BUSMAN
    22 HL S3B BUSMAN
    BTEC Y12
    BTEC Y13
    PPS Y12
    PPS Y13
    23 SL GloPo
    23 HL GloPo
    22 SL 223S GloPo
    22 HL 223S GloPo
    23 SL Psy
    23 HL Psy
    22 SL 22S3 Psy
    22 HL 22S3 Psy
    FRE B 12 SL
    FRE B 12 HL
    FRE B 13 SL
    FRE AI SL
    SPA B 12 SL
    SPA B 12 HL
    SPA 12 LD
    SPA 12 AI SL
    SPA B 13 SL
    SPA B 13 HL
    SPA 13 LD
    12 SL SEHS
    12 HL SEHS
    13 SL SEHS
    13 HL SEHS
    GER LL 12Z1 SL
    GER LL 12Z2 SL
    GER LL 12 HL
    GER LL 13Z1 SL
    GER LL 13Z2 SL
    GER LL 13 HL
    GER B 12 Z1 SL
    GER B 12 Z2 SL
    GER B 12 HL
    GER AI 12 Z1
    GER B 13 Z1 SL
    GER B 13 Z2 SL
    GER B 13 HL
    GER AI 13 Z1
    12 SL Visual Arts
    12 HL Visual Arts
    13 SL Visual Arts
    13 HL Visual Arts
    12 SL Theatre
    12 HL Theatre
    13 SL Theatre
    13 HL Theatre"""

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
    12
    12
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
    13
    13
    13
    12
    13
    12
    13
    12
    12
    13
    13
    12
    12
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
    13
    13
    13
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
    12
    12
    13
    13"""

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
    6
    4
    6
    4
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
    14
    14
    4
    4
    6
    4
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
    6
    4
    2
    6
    6
    4
    2
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
    4
    6
    4
    6
    4
    6
    4"""

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
    H7
    H5
    H6
    H6
    H10
    H10
    H10
    H10
    H8
    H8
    H10
    H9
    H8
    H9
    H8
    H9
    H8
    H9
    H8
    H1
    H1
    H5
    H5
    H12
    H12
    H11
    H11
    L1
    L3
    L3
    L1
    L6
    L6
    L3
    L5
    L6
    L6
    L3
    P2
    P3
    P1
    P3
    G2
    G3
    G2
    G2
    G3
    G2
    G7
    G4
    G7
    G8
    G7
    G4
    G7
    G5
    A3
    A3
    A4
    A4
    A1
    A1
    A1
    A1"""

    optionBlocks = """4
    4
    4
    6
    6
    4
    4
    4
    4
    4
    6
    6
    4
    4
    6
    6
    6
    6
    5
    5
    5
    5
    5
    5
    5
    5
    5
    5
    5
    5
    5
    1
    1
    1
    2
    2
    6
    1
    1
    2
    6
    3
    3
    3
    3
    3
    3
    3
    3
    3
    3
    3
    3
    3
    3
    6
    6
    3
    6
    3
    1,4
    1,4
    1,4
    1,4
    3
    3
    3
    3
    3
    3
    3
    3
    2
    2
    2
    2
    2
    2
    2
    2
    2
    2
    2
    6
    6
    6
    6
    1
    1
    1
    1
    1
    1
    2
    2
    2
    2
    2
    2
    2
    2
    6
    6
    6
    6
    6
    6
    6
    6"""

    groups = """SL
    HL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    HL
    SL
    HL
    HL
    SL
    HL
    HL
    SL
    SL
    SL
    HL
    SL
    SL
    HL
    HL
    HL
    HL
    SL
    HL
    HL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    SL
    HL
    HL
    HL
    HL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    SL
    SL
    HL
    HL
    SL
    SL
    HL
    SL
    SL
    HL
    SL
    HL
    SL
    SL
    HL
    SL
    SL
    HL
    SL
    SL
    HL
    SL
    SL
    SL
    HL
    SL
    SL
    HL
    SL
    HL
    SL
    HL
    SL
    HL"""

    names = names.split("\n")
    years = years.split("\n")
    numLessons = numLessons.split("\n")
    teachers = teachers.split("\n")
    optionBlocks = optionBlocks.split("\n")
    for b in optionBlocks:
        b.split(",")
    groups = groups.split("\n")
    # print(len(names), len(years), len(numLessons), len(teachers), len(optionBlocks), len(groups))
    # print(names[59], years[59], numLessons[59], teachers[59], optionBlocks[59], groups[59])

    classes = []
    for i in range(len(names)):
        classes.append(Lesson(names[i], years[i], numLessons[i], teachers[i], optionBlocks[i], groups[i]))

    # for c in classes:
    #     print(f"Name: {c.Name}  Year: {c.Year}  Lessons: {c.NumLessons}  Teacher: {c.Teacher}  Blocks: {c.Blocks}\
    #   Group: {c.Group}")

    for c in classes:
        try:
            print(cursor.execute(f'SELECT name FROM Teachers WHERE name = "%S8%")').fetchall())
            exit()
        except sqlite3.OperationalError as e:
            print(e)
            exit()
        values = {"Name": c.Name,
                  "Year": c.Year,
                  "Group": c.Group,
                  "ClassCode": c.Name,
                  "NumLessons": c.NumLessons,
                  "TeacherID": None,
                  "BlockID": None,
                  "RoomID": None,
                  "SaveID": None}


fillDB()
connection.close()
