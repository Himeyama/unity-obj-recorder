# 記録者

## 使用法
1. 「ヒエラルキー」タブを右クリックし、「空のオブジェクト」を作成する。
1. GameObject ができるので、これに Recorder.cs をアタッチする。
1. 位置が保存されるオブジェクト一覧の下にある Pos Objs に位置を記録したいオブジェクトをドラッグアンドドロップする。
1. 角度が記録されるオブジェクト一覧の下にある Rot Objs に角度を記録したいオブジェクトをドラッグアンドドロップする。
1. 保存先のディレクトリのパスを入力する。**注意: パスに空白があると保存できない**

> 例

<img src="https://user-images.githubusercontent.com/39254183/140328313-ce8511ed-56f8-4046-80d8-fa033a4e44b4.png" width="50%">

## ファイル名
保存ファイルは、指定したディレクトリの下に yyyyMMdd-HHmmss.csv の形式で保存されている。

## ファイルフォーマット
ファイルフォーマットは CSV 形式で、", " 区切りである。

|フレーム番号|時刻|PosObjs[0].x|PosObjs[0].y|PosObjs[0].z|PosObjs[1].x|PosObjs[1].y|PosObjs[1].z|...|RotObjs[0].x|RotObjs[0].y|RotObjs[0].z|RotObjs[1].x|RotObjs[1].y|RotObjs[1].z|...|
|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|

のような形式で保存されている。