<?php

namespace MyBlogBundle\Controller;

use MyBlogBundle\Entity\Article;
use MyBlogBundle\Entity\User;
use MyBlogBundle\Form\UserType;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Security;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class UserController extends Controller
{
    /**
     * @Route("/register", name="user_register")
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    function register(Request $request)
    {
        $user = new User();

        $form = $this->createForm(UserType::class, $user);
        $form->handleRequest($request);
        if ($form->isSubmitted() && $form->isValid()) {

            $password = $this->get('security.password_encoder')->encodePassword($user, $user->getPassword());

            $user->setPassword($password);

            $em = $this->getDoctrine()->getManager();
            $em->persist($user);
            $em->flush();

            return $this->redirectToRoute('security_login');
        }

        return $this->render('user/register.html.twig',
            [
                "form" => $form->createView()
            ]);
    }

    /**
     * @Route("/user/profile", name="user_profile")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function showProfile()
    {
        $user = $this->getUser();
        return $this->render('user/profile.html.twig',
            [
                "user" => $user
            ]);
    }

    /**
     * @Route("/user/articles", name="user_articles")
     * @Security("is_granted('IS_AUTHENTICATED_FULLY')")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function showMyArticles()
    {
        $repository = $this
            ->getDoctrine()
            ->getRepository(Article::class);

        $authorId = $this
            ->getUser()
            ->getId();

        $articles = $repository->findBy(
            ['authorId' => $authorId],
            ['dateAdded' => 'DESC']
        );

        return $this->render('user/articles.html.twig',
            [
                'articles' => $articles
            ]);
    }
}
