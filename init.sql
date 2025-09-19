begin transaction;

drop table if exists BookInfo;
drop table if exists CustomerInfo;
drop table if exists StaffInfo;

CREATE TABLE BookInfo (
Id INTEGER PRIMARY KEY NOT NULL,
Name        VARCHAR,
BookAuthor  VARCHAR,
BookCost    FLOAT,
BookQuality VARCHAR,
BookLentOut INTEGER,
BookDesc    VARCHAR,
BookTags    VARCHAR
);

INSERT INTO BookInfo (
Id,
Name,
BookAuthor,
BookCost,
BookQuality,
BookLentOut,
BookDesc,
BookTags
)
VALUES (
2,
'Age of Myth',
'Michael J. Sullivan',
13.5,
'Used',
1,
'This is a sample of what the description could look like. This could give a user more information about this book.',
'Fantasy, Fiction, Epic, Magic, Adventure, Elan, Riyria'
);

INSERT INTO BookInfo (
Id,
Name,
BookAuthor,
BookCost,
BookQuality,
BookLentOut,
BookDesc,
BookTags
)
VALUES (
4,
'World of Water',
'James Lovegrove',
9.99,
'Well Used',
0,
'This is a sample of what the description could look like. This could give a user more information about this book.',
'Science Fiction, Fiction, Adventure, Ocean, Harmer'
);

INSERT INTO BookInfo (
Id,
Name,
BookAuthor,
BookCost,
BookQuality,
BookLentOut,
BookDesc,
BookTags
)
VALUES (
5,
'The Meq',
'Steve Cash',
21.0,
'Well Used',
1,
'This is a sample of what the description could look like. This could give a user more information about this book.',
'Fantasy, Fiction, Science Fiction, Historical, Meq'
);

INSERT INTO BookInfo (
Id,
Name,
BookAuthor,
BookCost,
BookQuality,
BookLentOut,
BookDesc,
BookTags
)
VALUES (
7,
'Thief of Time',
'Terry Pratchett',
11.99,
'Used',
0,
'This is a sample of what the description could look like. This could give a user more information about this book.',
'Fantasy, Fiction, Humour, Death'
);

INSERT INTO BookInfo (
Id,
Name,
BookAuthor,
BookCost,
BookQuality,
BookLentOut,
BookDesc,
BookTags
)
VALUES (
8,
'The Name of the Wind',
'Patrick Rothfuss',
14.99,
'Used',
0,
'SAMPLE',
'Fantasy, Fiction, Magic, Adventure, Epic'
);

INSERT INTO BookInfo (
Id,
Name,
BookAuthor,
BookCost,
BookQuality,
BookLentOut,
BookDesc,
BookTags
)
VALUES (
9,
'Changer',
'Jane Lindskold',
7.99,
'Damaged',
0,
'SAMPLE',
'Fantasy, Fiction, Magic, Mythology'
);

INSERT INTO BookInfo (
Id,
Name,
BookAuthor,
BookCost,
BookQuality,
BookLentOut,
BookDesc,
BookTags
)
VALUES (
10,
'Textbook of General Zoology',
'Curtis and Gunthrie',
30.5,
'Well Used',
1,
NULL,
'Textbook, Zoology'
);

CREATE TABLE CustomerInfo (
Id           INTEGER PRIMARY KEY Not Null,
Name         VARCHAR,
Address      VARCHAR,
State        VARCHAR,
City         VARCHAR,
Country      VARCHAR,
ZipCode      VARCHAR,
EmailAddress VARCHAR,
PhoneNumber  VARCHAR
);

INSERT INTO CustomerInfo (
Id,
Name,
Address,
State,
City,
Country,
ZipCode,
EmailAddress,
PhoneNumber
)
VALUES (
4,
'Sara Johnson',
'456 5th Ave NW',
'AB',
'Calgary',
'Canada',
'T2P 4K5',
'sara.johnson@yahoo.ca',
'14033136241'
);

INSERT INTO CustomerInfo (
Id,
Name,
Address,
State,
City,
Country,
ZipCode,
EmailAddress,
PhoneNumber
)
VALUES (
32,
'Michael Brown',
'234 17th Ave NW',
'AB',
'Calgary',
'Canada',
'T2G 0H7',
'm.brown@gmail.com',
'14034267167'
);

INSERT INTO CustomerInfo (
Id,
Name,
Address,
State,
City,
Country,
ZipCode,
EmailAddress,
PhoneNumber
)
VALUES (
37,
'Emily Davis',
'321 20th St SW',
'AB',
'Calgary',
'Canada',
'T2N 1V5',
'davis_emily@outlook.com',
'14034042778'
);

INSERT INTO CustomerInfo (
Id,
Name,
Address,
State,
City,
Country,
ZipCode,
EmailAddress,
PhoneNumber
)
VALUES (
40,
'Andrew Kim',
'901 1St St NW',
'AB',
'Calgary',
'Canada',
'T2E 9T9',
'andrewk1m@gmail.com',
'14039422220'
);

CREATE TABLE StaffInfo (
Id         INTEGER PRIMARY KEY NOT NULL,
Name       VARCHAR,
StaffLname VARCHAR,
StaffEmail VARCHAR,
Number     VARCHAR
);

INSERT INTO StaffInfo (
Id,
Name,
StaffLname,
StaffEmail,
Number
)
VALUES (
1,
'John',
'Smyth',
'j.symth@deweydash.ca',
'14036671225'
);

commit;