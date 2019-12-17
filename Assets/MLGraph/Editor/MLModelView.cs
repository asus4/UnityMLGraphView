using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.GraphView;


namespace MLGraph
{

    public class MLModelView : GraphView
    {
        public MLModelView() : base()
        {
            SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale, ContentZoomer.DefaultScaleStep, ContentZoomer.DefaultReferenceScale);
            Insert(0, new GridBackground());


            AddElement(new MLNode());


            // Add manupirator

            nodeCreationRequest += (NodeCreationContext context) =>
            {
                Debug.Log(context);

                var node = new MLNode();
                var pos = node.GetPosition();
                pos.x += context.screenMousePosition.x;
                pos.y += context.screenMousePosition.y;
                node.SetPosition(pos);
                node.UpdatePresenterPosition();
                AddElement(node);
            };
        }

        public override List<Port> GetCompatiblePorts(Port startPort, NodeAdapter nodeAdapter)
        {
            return ports.ToList();
        }
    }
}
