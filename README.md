# VP-Proekt-2017
Windows Forms Project by Anastasija Makashevska (143007)
================

<b>Објаснување на проблемот</b>

Апликацијата претставува едноставна верзија на играта бесилка. Добро позната игра е имплементирана така што се погодува некој збор од претходно одбрана категорија. Играчот има 6 обиди за да го погоди зборот, па затоа колку е поголем зборот толку повеќе поени се собираат.

<b>Правила за игра</b>

Најпрво корисникот мора да одбере категорија од која ќе припаѓа зборот кој се погодува. Можни категории се: предмети, имиња, градови и спортови. При процесот на играње една буква може да се одбере само еднаш, по што ако не ја погоди буквата се оди црта еден дел од телото на човечето, а ако ја погоди се прикажува буквата на сите позиции на кои ја има истата. Ако успее да го погоди зборот без да згреши 6 пати (целото тело на чевечето да биде обесено), тогаш играчот победил и може да дознае колку поени освоил.


<b>Имплементација на решението</b>

<u>Преглед на компонентите:</u>

		4 форми (Form1, PlayGame, GameOver, CongratsForm)
		 
		<u>Класи:</u>
		
			* Category.cs - класа за репрезентација на категоријата на која може да припаѓаат зборовите кои се погодуваат (со 2 propreties: Id, Name)
			* WordToGuess.cs - класа за репрезентација на самите зборови кои се погодуваат (содржи 2 propreties: категоријата на кој аи припаѓа и самиот збор)
			* Game.cs - класата претставува импорвизирана база на категории и зборови од соодветни категории, плус дополнителено нуди функционалност за враќање на случаен збор од некојa категорија на зборови. Зборовите и категориите се чуваат во генерички листи List<WordToGuess> и List<Category>.



