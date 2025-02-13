﻿ /*Copyright © 2018 HiFi Ltd - All Rights Reserved
 * This file is part of Positional Content which is released under the HiFi Positional Content License.
 * Please visit : http://www.positionalcontent.com/PositionalContentLicenseAgreement.pdf for full license details
 */

angular.module("umbraco").controller("HiFi.PositionalContent.PropertyEditorInitialDimensions", [
    '$scope',
    'editorService',
    function ($scope, editorService) {
        $scope.openDimensionDialog = function () {
            editorService.open({
                view: '../App_Plugins/PositionalContent/contenteditor/positionalcontenteditor.dimension.html',
                dialogData: {
                    title: 'Initial item dimensions',
                    isItem: true,
                    state: {
                        active: {
                            name: 'initial'
                        }
                    },
                    data: {
                        dimensions: {
                            initial: $scope.model.value
                        }
                    }
                },
                size: 'small',
                modalClass: 'positional-content-dialog-wrapper',
                callback: function (data) {
                    $scope.mode.value = data.data.dimensions.intial;
                }
            });
        }
       

    }]
);