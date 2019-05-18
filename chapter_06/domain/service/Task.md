﻿# ６章課題
## インスタンスとクラス
domain.service配下に下記設問に沿ってクラスを作成せよ
### 問１
聖騎士「パラディン」を表現するクラスPaladinを作成せよ  
クラス名、ファイル名はPaladinBy＋社員番号とする  
ex. PaladinBy092
### 問２
パラディンクラスは下記の基本能力を備えている  
それぞれを属性として定義せよ  
「名前」「ライフ」「マナ」「最大ライフ」「最大マナ」  
最大ライフは初期値55、最大マナは15とする  
属性は適切と思われる型で定義すること  
最大ライフ、最大マナは定数で定義すること
### 問３
パラディンは下記のスキルが使用できる  
スキルの特徴を読んで操作を実装せよ  
・Combat Skill … Zeal(ジール)、最大5回攻撃対象へと打撃攻撃を行う。相手へのダメージ(3～7/1回)、マナコスト(2)  
・Offensive Aura … Fanaticism(ファナティシズム)、物理ダメージ(373%)・命中率(135%)・攻撃速度(35%)を引き上げる  
・Defensive Aura … Meditation(メディテイション)、ライフ回復(10～15)、マナ回復(3～5)を行う  
スキルの発動は画面上に文字で表せれば良い  
ex. Zeal使用時↓  
パラディン進一はZealで攻撃！  
ガッガッガッガッガッ！  
5Hit！  
5,3,5,4,7のダメージを与えた!  
マナを2消費した
### ヒント
クラスをどのように定義するかわからない場合、クラス図(PaladinClass.png)を確認すること  
### クラス作成後
MainController.makeCharacterメソッドの自身のemployeeIdに該当するコメントを解除して動作を確認せよ