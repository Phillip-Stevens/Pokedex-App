-- CREATION OF THE TABLES FOR THE POKEDEX
-- 		Written by: Phillip Stevens

-- ELEMENT TABLE (CONTAINS A LIST OF ALL TYPE OPTIONS)
CREATE TABLE ELEMENTS(
	ELEMENT VARCHAR(20) NOT NULL,
	CONSTRAINT PK_ELEMENT PRIMARY KEY (ELEMENT)
);

-- GENERATION TABLE (CONTAINS A LIST OF ALL THE GENERATION OPTIONS)
CREATE TABLE GENERATIONS(
	GENERATION INTEGER NOT NULL,
	CONSTRAINT PK_GENERATION PRIMARY KEY (GENERATION)
);

-- POKEMON TABLE (Main Table) Primary key is the entry number and the foreign keys are the elements and generation
CREATE TABLE POKEMON (
	ENTRYNUMBER INTEGER IDENTITY(1, 1) PRIMARY KEY,
	NAME VARCHAR(20) NOT NULL,
	DESCRIPTION VARCHAR(255),
	ELEMENT VARCHAR(20) NOT NULL,
	ELEMENTTWO VARCHAR(20),
	GENERATION INTEGER NOT NULL,
	CONSTRAINT FK_ELEMENT FOREIGN KEY (ELEMENT) REFERENCES ELEMENTS (ELEMENT),
	CONSTRAINT FK_ELEMENT2 FOREIGN KEY (ELEMENTTWO) REFERENCES ELEMENTS (ELEMENT),
	CONSTRAINT FK_GENERATION FOREIGN KEY (GENERATION) REFERENCES GENERATIONS (GENERATION)
);

-- INSERT POKEMON TYPES FOR POKEMON (11 UNIQUE TYPES AS OF GENERATION ONE OF POKEMON WITH DUAL TYPING TAKING ADVANTAGE OF REFERENCING THE SAME TABLE!)
INSERT INTO ELEMENTS VALUES ('BUG');
INSERT INTO ELEMENTS VALUES ('DRAGON');
INSERT INTO ELEMENTS VALUES ('ELECTRIC');
INSERT INTO ELEMENTS VALUES ('FIGHTING');
INSERT INTO ELEMENTS VALUES ('FIRE');
INSERT INTO ELEMENTS VALUES ('FLYING');
INSERT INTO ELEMENTS VALUES ('GRASS');
INSERT INTO ELEMENTS VALUES ('GROUND');
INSERT INTO ELEMENTS VALUES ('NORMAL');
INSERT INTO ELEMENTS VALUES ('POISON');
INSERT INTO ELEMENTS VALUES ('PSYCHIC');
INSERT INTO ELEMENTS VALUES ('WATER');
INSERT INTO ELEMENTS VALUES ('NONE');

-- INSERT GENERATION NUMBERS
INSERT INTO GENERATIONS VALUES (1);
INSERT INTO GENERATIONS VALUES (2);
INSERT INTO GENERATIONS VALUES (3);
INSERT INTO GENERATIONS VALUES (4);
INSERT INTO GENERATIONS VALUES (5);
INSERT INTO GENERATIONS VALUES (6);

-- INSERT POKEMON INTO POKEMON
INSERT INTO POKEMON VALUES ('BULBASAUR', 'A strange seed was planted on its back at birth. The plant sprouts and grows with this POKéMON.', 'GRASS', 'POISON', 1);
INSERT INTO POKEMON VALUES ('IVYSAUR', 'When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.', 'GRASS', 'POISON', 1);
INSERT INTO POKEMON VALUES ('VENUSAUR', 'The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.', 'GRASS', 'POISON', 1);
INSERT INTO POKEMON VALUES ('CHARMANDER', 'Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.', 'FIRE', 'NONE', 1);
INSERT INTO POKEMON VALUES ('CHARMELEON', 'When it swings its burning tail, it elevates the temperature to unbearably high levels.', 'FIRE', 'NONE', 1);
INSERT INTO POKEMON VALUES ('CHARIZARD', 'Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.', 'FIRE', 'FLYING', 1);
INSERT INTO POKEMON VALUES ('SQUIRTLE', 'After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.', 'WATER', 'NONE', 1);
INSERT INTO POKEMON VALUES ('WARTORTLE', 'Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance.', 'WATER', 'NONE', 1);
INSERT INTO POKEMON VALUES ('BLASTOISE', 'A brutal POKéMON with pressurized water jets on its shell. They are used for high speed tackles.', 'WATER', 'NONE', 1);
INSERT INTO POKEMON VALUES ('CATERPIE', 'Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.', 'BUG', 'NONE', 1);
INSERT INTO POKEMON VALUES ('METAPOD', 'This POKéMON is vulnerable to attack while its shell is soft, exposing its weak and tender body.', 'BUG', 'NONE', 1);
INSERT INTO POKEMON VALUES ('BUTTERFREE', 'In battle, it flaps its wings at high speed to release highly toxic dust into the air.', 'BUG', 'FLYING', 1);
INSERT INTO POKEMON VALUES ('WEEDLE', 'Often found in forests, eating leaves. It has a sharp venomous stinger on its head.', 'BUG', 'POISON', 1);
INSERT INTO POKEMON VALUES ('KAKUNA', 'Almost incapable of moving, this POKéMON can only harden its shell to protect itself from predators.', 'BUG', 'POISON', 1);
INSERT INTO POKEMON VALUES ('BEEDRILL', 'Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.', 'BUG', 'POISON', 1);
INSERT INTO POKEMON VALUES ('PIDGEY', 'A common sight in forests and woods. It flaps its wings at ground level to kick up blinding sand.', 'NORMAL', 'FLYING', 1);
INSERT INTO POKEMON VALUES ('PIDGEOTTO', 'Very protective of its sprawling territorial area, this POKéMON will fiercely peck at any intruder.', 'NORMAL', 'FLYING', 1);
INSERT INTO POKEMON VALUES ('PIDGEOT', 'When hunting, it skims the surface of water at high speed to pick off unwary prey such as MAGIKARP.', 'NORMAL', 'FLYING', 1);

