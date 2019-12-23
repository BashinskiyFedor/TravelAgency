"use strict"
{
    // ��������� ��� ������������ ������� output ����
    let path = require('path');

    // ������ ��� ������� �������� ����� (bundle) ����� ��������� �����
    const CleanWebpackPlugin = require('clean-webpack-plugin');

    // ���� � �������� �����
    const bundleFolder = "wwwroot/bundle/";

    module.exports = {
        // ����� ����� � ����������
        entry: "./Scripts/main.ts",

        // �������� ����
        output: {
            filename: 'script.js',
            path: path.resolve(__dirname, bundleFolder)
        },
        module: {
            rules: [
                {
                    test: /\.tsx?$/,
                    loader: "ts-loader",
                    exclude: /node_modules/,
                },
            ]
        },
        resolve: {
            extensions: [".tsx", ".ts", ".js"]
        },
        plugins: [
            new CleanWebpackPlugin([bundleFolder])
        ],
        // �������� ��������� ���������� ���������� ������ ��������� �����
        // (����� ��� ������ ������� ���������� ��������)
        devtool: "inline-source-map"
    };
}