# ⚔️ Infinite Knight Runner

Un jeu de plateforme 2D infini développé avec **Unity 2022+**. Incarnez un chevalier courageux, sautez d'île en île et survivez le plus longtemps possible pour atteindre le score ultime !

---

## 🎮 Comment Jouer ?

1. **Lancer le jeu** : Appuyez sur n'importe quelle touche du clavier ou cliquez avec la souris pour commencer.
2. **Sauter** : Appuyez sur **n'importe quelle touche** (Espace, Clic Souris, etc.) pour sauter de plateforme en plateforme.
3. **Objectif** : Ne tombez pas dans le vide ! Le score augmente tant que vous êtes en vie. Si vous tombez, la partie recommence automatiquement.

---

## 🛠️ Fonctionnalités Techniques

Ce projet a été l'occasion de mettre en pratique plusieurs concepts clés de Unity :

* **Génération Procédurale** : Un `IslandSpawner` génère des îles de tailles et de hauteurs aléatoires à l'aide d'un système de *Prefabs*.
* **Système d'Animation** : Utilisation d'un *Animator Controller* avec des transitions d'états (`isJumping`) pour passer du mode course au mode saut.
* **Physique 2D** : Gestion des collisions via *Rigidbody 2D* et *Box Collider 2D*, avec verrouillage de la rotation pour la stabilité du personnage.
* **UI & Score** : Affichage dynamique du score en temps réel avec *TextMeshPro*.
* **Gestion des Calques (Layers)** : Organisation du rendu via les *Sorting Layers* pour séparer le background, les plateformes et le joueur.
* **Game Loop** : Système de "Death Zone" automatique qui recharge la scène via le *SceneManager*.

---

## 📁 Installation (Pour les développeurs)

Si vous souhaitez ouvrir ce projet dans Unity :

1. Clonez le dépôt : 
   ```bash
   git clone [https://github.com/VOTRE_PSEUDO/InfiniteRunner.git](https://github.com/VOTRE_PSEUDO/InfiniteRunner.git)
   ```
   
2. Ouvrez le dossier avec Unity Hub.

3. Assurez-vous d'avoir installé le package Input System (via le Package Manager) car le jeu utilise les nouvelles entrées globales.


Lien Assets : 

https://assetstore.unity.com/packages/2d/characters/knight-sprite-sheet-free-93897
https://assetstore.unity.com/packages/2d/environments/pixel-art-woods-tileset-and-background-280066

1. Clonez le dépôt : 
   ```bash
   git clone [https://github.com/VOTRE_PSEUDO/InfiniteRunner.git](https://github.com/VOTRE_PSEUDO/InfiniteRunner.git)
